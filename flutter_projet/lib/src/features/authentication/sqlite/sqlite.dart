//import 'dart:ffi';

import 'dart:io';

import 'package:path/path.dart';
import 'package:sqflite/sqflite.dart';
import 'package:path_provider/path_provider.dart';
import '../models/inventoryitem.dart';
import '../models/users.dart';

class DatabaseHelper{

  final databaseName = "ScannerApp.db";

  String users =
      "create table users (usrId INTEGER PRIMARY KEY , usrFullName TEXT ,usrPhone INTEGER, usrPassword TEXT,usrType INTEGER  DEFAULT 0)";
  String inventory =
      "CREATE TABLE IF NOT EXISTS inventory ("
      "id INTEGER PRIMARY KEY,"
      "REG TEXT,"
      "SITE TEXT,"
      "LIEU TEXT,"
      "CDLIEU TEXT,"
      "ETAT TEXT,"
      "NOMI TEXT,"
      "CODEI TEXT,"
      "ETATI TEXT,"
      "date TEXT,"
  " usrId INTEGER,"
  "FOREIGN KEY (usrId) REFERENCES users(usrId))";

  Future<Database> initDB() async {
    final Directory directory = await getApplicationDocumentsDirectory();
    final path = join(directory.path, databaseName);

    return openDatabase(path, version: 6, onCreate: (db, version) async {
      await db.execute(users);
      await db.execute(inventory);

    });
  }
  //login in
  Future<bool> login(Users user) async {
    final Database db = await initDB();

    // I forgot the password to check
    var result = await db.rawQuery(
        "select * from users where usrId = '${user.usrId}' AND usrPassword = '${user.usrPassword}'");
    if (result.isNotEmpty) {
      return true;

    } else {
      return false;
    }
  }

  //Sign up
  Future<void> signup(Users user) async {
    final Database db = await initDB();
    await db.rawQuery(
        "INSERT INTO users (usrId, usrFullName, usrPhone, usrPassword) VALUES ('${user.usrId}','${user.usrFullName}','${user.usrPhone}','${user.usrPassword}')");

  }

  Future<void> Connecter(Users user) async {
    final Database db = await initDB();

    await db.update(
      'users',
      {'usrType': 1}, // Nouvelle valeur du champ usrType
      where: 'usrId = ? AND usrPassword = ?', // Clause WHERE
      whereArgs: [user.usrId, user.usrPassword], // Arguments de la clause WHERE
    );
  }
  Future<void> Deconnecter() async {
    final Database db = await initDB();

    await db.update(
      'users',
      {'usrType': 0}, // Nouvelle valeur du champ usrType
      where: 'usrType=1', // Clause WHERE

    );
  }



  Future<List<Map<String, dynamic>>> getData() async {
    var db = await initDB();
    var reponse = await db.query( "users");
    print (reponse);
    return reponse;

  }
  //////////////////////////////////INVENTORY////////////////////////////////////////////////////////
  Future<void> insertInventoryItem(InventoryItem item) async {
    final  db = await initDB();
    await db.insert(
      'inventory',
      item.toMap(),
      conflictAlgorithm: ConflictAlgorithm.replace,
    );
  }



  Future<List<InventoryItem>> fetchInventoryItemsFromDatabase() async {
    final database = await initDB();


    final List<Map<String, dynamic>> maps = await database.query('inventory');

    return List.generate(maps.length, (i) {
      return InventoryItem(
        REG: maps[i]['REG'],
        SITE: maps[i]['SITE'],
        LIEU: maps[i]['LIEU'],
        CDLIEU: maps[i]['CDLIEU'],
        ETAT: maps[i]['ETAT'],
        NOMI: maps[i]['NOMI'],
        CODEI: maps[i]['CODEI'],
        ETATI: maps[i]['ETATI'],
          usrId: maps[i]['usrId'],
          date: maps[i]['date']

      );
    });
  }



  Future<List<Map<String, Object?>>> getusrId() async {
    final Database db = await initDB();
   return await db.rawQuery(
        "SELECT usrId FROM users WHERE usrType = 1 LIMIT 1");


    }


  deleteData(String table, String? where) async {
    final Database db = await initDB();
    int response = await db.delete(table, where: where);
    return response;
  }

  dropInv() async {
    final Database db = await initDB();
    await db.execute("DROP TABLE 'inventory'");
    print("table droped !!!!");

      await db.execute("CREATE TABLE  inventory (id INTEGER PRIMARY KEY,REG TEXT,SITE TEXT,LIEU TEXT,CDLIEU TEXT,ETAT TEXT,NOMI TEXT,CODEI TEXT,ETATI TEXT,date TEXT,usrId INTEGER,FOREIGN KEY (usrId) REFERENCES users(usrId))");
    print("table created !!!!");
  }



  readData() async {
    final Database db = await initDB();
    List<Map> response = await db.query('inventory');
    return response;
  }

  Future<List<InventoryItem>> fetchFilteredInventoryItemsFromDatabase(String nomi) async {
    final database = await initDB();

    final List<Map<String, dynamic>> maps = await database.query('inventory', where: 'NOMI = ?', whereArgs: [nomi]);

    return List.generate(maps.length, (i) {
      return InventoryItem(
          REG: maps[i]['REG'],
          SITE: maps[i]['SITE'],
          LIEU: maps[i]['LIEU'],
          CDLIEU: maps[i]['CDLIEU'],
          ETAT: maps[i]['ETAT'],
          NOMI: maps[i]['NOMI'],
          CODEI: maps[i]['CODEI'],
          ETATI: maps[i]['ETATI'],
          usrId: maps[i]['usrId'],
          date: maps[i]['date']
      );
    });
  }




}