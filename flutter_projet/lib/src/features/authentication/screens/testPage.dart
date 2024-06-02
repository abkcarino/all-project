import 'package:flutter/material.dart';
import 'package:engtpscanner/src/features/authentication/sqlite/sqlite.dart';

class testPage extends StatelessWidget {
  const testPage({super.key});

  @override
  Widget build(BuildContext context) {

    final db = DatabaseHelper();
    String getUserTypeString(int userType) {
      switch (userType) {
        case 0:
          return "Type 0";
        case 1:
          return "Type 1";
      // Ajoutez d'autres cas au besoin
        default:
          return "Inconnu";
      }
    }
    return Scaffold(
      appBar: AppBar(
        title: const Text('Test Page'),
      ),
      body: FutureBuilder(
        future: db.getData(),
        builder: (context, snapshot) {
          if (snapshot.connectionState == ConnectionState.waiting) {
            return const Center(
              child: CircularProgressIndicator(),
            );
          } else if (snapshot.hasError) {
            return Center(
              child: Text('Error: ${snapshot.error}'),
            );
          } else {
            List<Map<String, dynamic>> data = snapshot.data as List<Map<String, dynamic>>;
            return SingleChildScrollView(
              scrollDirection: Axis.horizontal,
              child: DataTable(
                columns: const [
                  DataColumn(label: Text("Matricule")),
                  DataColumn(label: Text("Nom complet")),
                  DataColumn(label: Text("Téléphone")),
                  DataColumn(label: Text("Mot de passe")),
                  DataColumn(label: Text("Type")),
                ],
                rows: data.map((e) => DataRow(cells: [
                  DataCell(Text(e["usrId"].toString())),
                  DataCell(Text(e["usrFullName"] ?? '')),
                  DataCell(Text(e["usrPhone"]?.toString() ?? '')),
                  DataCell(Text(e["usrPassword"] ?? '')),
                  DataCell(Text(e["usrType"].toString()) ),
                ])).toList(),
              ),
            );
          }
        },
      ),
    );
  }
}
