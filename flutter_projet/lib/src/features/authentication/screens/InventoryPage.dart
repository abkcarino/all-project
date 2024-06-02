import 'dart:io';

import 'package:flutter/material.dart';
import 'package:path/path.dart';
import '../models/inventoryitem.dart';
import 'package:engtpscanner/src/features/authentication/sqlite/sqlite.dart';
import 'package:pdf/pdf.dart';
import 'package:pdf/widgets.dart' as pw;

class InventoryPage extends StatefulWidget {
  const InventoryPage({Key? key}) : super(key: key);

  @override
  _InventoryPageState createState() => _InventoryPageState();
}

class _InventoryPageState extends State<InventoryPage> {
  TextEditingController nomi = TextEditingController();
  late Future<List<InventoryItem>> _inventoryItems;
  final db = DatabaseHelper();

  @override
  void initState() {
    super.initState();
    _inventoryItems = db.fetchInventoryItemsFromDatabase();
  }

  Future<void> dropDB() async {
    await db.dropInv();
  }

  Future<void> exportInventaireToTextFile() async {
    final List<Map<String, dynamic>> data = await db.readData();
    Directory appSupportDir = Directory('/storage/emulated/0/Documents/');

    if (appSupportDir != null) {
      final currentDate = DateTime.now();
      final formattedDateTime =
          "${currentDate.year}-${currentDate.month}-${currentDate.day}_${currentDate.hour}-${currentDate.minute}-${currentDate.second}";
      String sqlFilePath =
      join(appSupportDir.path, 'inventory$formattedDateTime.txt');
      final outputFile = File(sqlFilePath);
      final sink = outputFile.openWrite();

      for (final row in data) {
        final REG = row['REG'];
        final SITE = row['SITE'];
        final LIEU = row['LIEU'];
        final CDLIEU = row['CDLIEU'];
        final ETAT = row['ETAT'];
        final NOMI = row['NOMI'];
        final CODEI = row['CODEI'];
        final ETATI = row['ETATI'];
        final date = row['date'];

        final insertSql =
            "'$REG', '$SITE', '$LIEU', '$CDLIEU', '$ETAT', '$NOMI', '$CODEI', '$ETATI',  '$date'";
        sink.writeln(insertSql);
      }
      await sink.flush();
      await sink.close();
    } else {
      print("le directory n'existe pas ............!!");
    }
  }

  Future<void> exportInventaireToSQLFile() async {
    final List<Map<String, dynamic>> data = await db.readData();
    Directory appSupportDir = Directory('/storage/emulated/0/Documents/');

    if (appSupportDir != null) {
      final currentDate = DateTime.now();
      final formattedDateTime =
          "${currentDate.year}-${currentDate.month}-${currentDate.day}_${currentDate.hour}-${currentDate.minute}-${currentDate.second}";
      String sqlFilePath =
      join(appSupportDir.path, 'inventory$formattedDateTime.sql');
      final outputFile = File(sqlFilePath);
      final sink = outputFile.openWrite();

      for (final row in data) {
        final REG = row['REG'];
        final SITE = row['SITE'];
        final LIEU = row['LIEU'];
        final CDLIEU = row['CDLIEU'];
        final ETAT = row['ETAT'];
        final NOMI = row['NOMI'];
        final CODEI = row['CODEI'];
        final ETATI = row['ETATI'];
        final date = row['date'];

        final insertSql =
            "'$REG', '$SITE', '$LIEU', '$CDLIEU', '$ETAT', '$NOMI', '$CODEI', '$ETATI',  '$date'";
        sink.writeln(insertSql);
      }
      await sink.flush();
      await sink.close();
    } else {
      print("le directory n'existe pas ............!!");
    }
  }

  Future<void> exportInventaireToPdf() async {
    final List<Map<String, dynamic>> data = await db.readData();
    Directory appSupportDir = Directory('/storage/emulated/0/Documents/');

    if (appSupportDir != null) {
      final currentDate = DateTime.now();
      final formattedDateTime =
          "${currentDate.year}-${currentDate.month}-${currentDate.day}_${currentDate.hour}-${currentDate.minute}-${currentDate.second}";
      String pdfFilePath =
      join(appSupportDir.path, 'inventory$formattedDateTime.pdf');

      final pdf = pw.Document();

      final tableDataTextStyle = pw.TextStyle(fontSize: 10);

      pdf.addPage(
        pw.Page(
          build: (pw.Context context) {
            return pw.Center(
              child: pw.Text(
                'Liste des investissements',
                style: pw.TextStyle(fontSize: 20),
              ),
            );
          },
        ),
      );

      pdf.addPage(
        pw.Page(
          build: (pw.Context context) {
            final List<pw.TableRow> rows = [
              pw.TableRow(
                children: [
                  pw.Text('No', style: pw.TextStyle(fontWeight: pw.FontWeight.bold)),
                  pw.Text('REG', style: pw.TextStyle(fontWeight: pw.FontWeight.bold)),
                  pw.Text('SITE', style: pw.TextStyle(fontWeight: pw.FontWeight.bold)),
                  pw.Text('LIEU', style: pw.TextStyle(fontWeight: pw.FontWeight.bold)),
                  pw.Text('CDLIEU', style: pw.TextStyle(fontWeight: pw.FontWeight.bold)),
                  pw.Text('ETAT', style: pw.TextStyle(fontWeight: pw.FontWeight.bold)),
                  pw.Text('NOMI', style: pw.TextStyle(fontWeight: pw.FontWeight.bold)),
                  pw.Text('CODEI', style: pw.TextStyle(fontWeight: pw.FontWeight.bold)),
                  pw.Text('ETATI', style: pw.TextStyle(fontWeight: pw.FontWeight.bold)),
                  pw.Text('date', style: pw.TextStyle(fontWeight: pw.FontWeight.bold)),
                ],
              ),
              for (int i = 0; i < data.length; i++)
                pw.TableRow(
                  children: [
                    pw.Text('${i + 1}', style: tableDataTextStyle),
                    pw.Text('${data[i]['REG']}', style: tableDataTextStyle),
                    pw.Text('${data[i]['SITE']}', style: tableDataTextStyle),
                    pw.Text('${data[i]['LIEU']}', style: tableDataTextStyle),
                    pw.Text('${data[i]['CDLIEU']}', style: tableDataTextStyle),
                    pw.Text('${data[i]['ETAT']}', style: tableDataTextStyle),
                    pw.Text('${data[i]['NOMI']}', style: tableDataTextStyle),
                    pw.Text('${data[i]['CODEI']}', style: tableDataTextStyle),
                    pw.Text('${data[i]['ETATI']}', style: tableDataTextStyle),
                    pw.Text('${data[i]['date']}', style: tableDataTextStyle),
                  ],
                ),
            ];
            return pw.Table(
              children: rows,
              border: pw.TableBorder.all(color: PdfColors.black),
            );
          },
        ),
      );

      final File file = File(pdfFilePath);
      await file.writeAsBytes(await pdf.save());

      print('PDF créé avec succès : $pdfFilePath');
    } else {
      print("Le répertoire n'existe pas...");
    }
  }

  @override
  Widget build(BuildContext context) {
    return Scaffold(
      appBar: AppBar(
        title: const Text('Inventory'),
        actions: [
          PopupMenuButton<String>(
            onSelected: (value) async {
              if (value == 'Option 1') {
                exportInventaireToPdf();
                ScaffoldMessenger.of(context).showSnackBar(
                  const SnackBar(content: Text('Exportation PDF réussie')),
                );
              } else if (value == 'Option 2') {
                exportInventaireToTextFile();
                ScaffoldMessenger.of(context).showSnackBar(
                  const SnackBar(content: Text('Exportation TXT réussie')),
                );
              } else if (value == 'Option 3') {
                exportInventaireToSQLFile();
                ScaffoldMessenger.of(context).showSnackBar(
                  const SnackBar(content: Text('Exportation SQL réussie')),
                );
              } else if (value == 'Option 4') {
                await dropDB();
                ScaffoldMessenger.of(context).showSnackBar(
                  const SnackBar(content: Text('Base de données supprimée avec succès')),
                );
              }
            },
            itemBuilder: (BuildContext context) {
              return <PopupMenuEntry<String>>[
                const PopupMenuItem<String>(
                  value: 'Option 1',
                  child: Text('Exporter les données PDF'),
                ),
                const PopupMenuItem<String>(
                  value: 'Option 2',
                  child: Text('Exporter les données TXT'),
                ),
                const PopupMenuItem<String>(
                  value: 'Option 3',
                  child: Text('Exporter les données SQL'),
                ),
                const PopupMenuItem<String>(
                  value: 'Option 4',
                  child: Text('Supprimer les données'),
                ),
              ];
            },
          ),
        ],
      ),
      floatingActionButton: FloatingActionButton(
        onPressed: () {
          showDialog(
            context: context,
            builder: (BuildContext context) {
              return AlertDialog(
                title: Text('Filtrer par nom investissements'),
                content: TextFormField(
                  controller: nomi,
                  decoration: const InputDecoration(
                    focusedBorder: OutlineInputBorder(
                      borderSide: BorderSide(color: Colors.blue),
                    ),
                    border: OutlineInputBorder(),
                    labelText: 'nomi',
                    labelStyle: TextStyle(color: Colors.blue),
                  ),
                ),
                actions: <Widget>[
                  TextButton(
                    child: Text('Annuler'),
                    onPressed: () {
                      Navigator.of(context).pop();
                    },
                  ),
                  TextButton(
                    child: Text('Filtrer'),
                    onPressed: () {
                      setState(() {
                        _inventoryItems =
                            db.fetchFilteredInventoryItemsFromDatabase(nomi.text);
                      });
                      Navigator.of(context).pop();
                    },
                  ),
                ],
              );
            },
          );
        },
        child: Icon(Icons.search),
      ),
      body: FutureBuilder<List<InventoryItem>>(
        future: _inventoryItems,
        builder: (context, snapshot) {
          if (snapshot.connectionState == ConnectionState.waiting) {
            return const Center(child: CircularProgressIndicator());
          } else if (snapshot.hasError) {
            return Center(child: Text('Error: ${snapshot.error}'));
          } else if (!snapshot.hasData || snapshot.data!.isEmpty) {
            return const Center(child: Text('No data available'));
          } else {
            return ListView.builder(
              itemCount: snapshot.data!.length,
              itemBuilder: (context, index) {
                final item = snapshot.data![index];
                return Card(
                  child: ListTile(
                    title: Text('REG: ${item.REG}'),
                    subtitle: Column(
                      crossAxisAlignment: CrossAxisAlignment.start,
                      children: [
                        Text('SITE: ${item.SITE}'),
                        Text('LIEU: ${item.LIEU}'),
                        Text('CDLIEU: ${item.CDLIEU}'),
                        Text('ETAT: ${item.ETAT}'),
                        Text('NOMI: ${item.NOMI}'),
                        Text('CODEI: ${item.CODEI}'),
                        Text('ETATI: ${item.ETATI}'),
                        Text('date: ${item.date}'),
                      ],
                    ),
                    trailing: Row(
                      mainAxisSize: MainAxisSize.min,
                      children: [
                        IconButton(
                          onPressed: () async {
                            int response = await db.deleteData("inventory", 'CODEI = ${item.CODEI}');
                            if (response > 0) {
                              setState(() {
                                snapshot.data!.removeWhere((element) => element.CODEI == item.CODEI);
                              });
                            }
                          },

                          icon: const Icon(Icons.delete),
                        ),
                      ],
                    ),
                  ),
                );
              },
            );
          }
        },
      ),
    );
  }
}
