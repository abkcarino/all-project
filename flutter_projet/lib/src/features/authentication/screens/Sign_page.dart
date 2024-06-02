import 'package:flutter/material.dart';
import 'package:engtpscanner/src/features/authentication/screens/Login_page.dart';
import 'package:engtpscanner/src/features/authentication/sqlite/sqlite.dart';
import '../models/users.dart';

class SignPage extends StatefulWidget {
  const SignPage({super.key});

  @override
  _SignPageState createState() => _SignPageState();
}
class _SignPageState extends State<SignPage> {
  final GlobalKey<FormState> formKey = GlobalKey<FormState>();
  final  matriculeController = TextEditingController();
  final  fullNameController = TextEditingController();
  final  phoneController = TextEditingController();
  final  passwordController = TextEditingController();

  @override
  Widget build(BuildContext context) {
    var size = MediaQuery.of(context).size;
    return Scaffold(
      body: SingleChildScrollView(
        child: Container(
          padding: const EdgeInsets.all(30),
          child: Form(
            key: formKey,
          child: Column(
            crossAxisAlignment: CrossAxisAlignment.start,
            children: [
              Image(image: const AssetImage('assets/images/welcome_image1.png'), height: size.height * 0.3),
              const SizedBox(height: 10),
              Text("Signez ici", style: Theme.of(context).textTheme.displayMedium,),
              Text("Creer un compte pour accéder à engtp scanner", style: Theme.of(context).textTheme.bodyLarge,),

                 Container(
                  padding: const EdgeInsets.symmetric(vertical: 20),
                  child: Column(
                    crossAxisAlignment: CrossAxisAlignment.start,
                    children: [
                      TextFormField(
                        keyboardType: TextInputType.number,
                        controller : matriculeController,
                        maxLength: 9,
                        validator: (value) {
                          if (value == null || value.isEmpty||value.length!=9) {
                            return 'Champ obligatoire';
                          }
                          return null;
                        },
                        decoration: const InputDecoration(
                          prefixIcon: Icon(Icons.person_outline_outlined, color: Colors.black),
                          labelText: "Matricule",
                          labelStyle: TextStyle(
                              color: Colors.blue
                          ),
                          hintText: "Matricule",

                          border: OutlineInputBorder(),
                          focusedBorder: OutlineInputBorder(borderSide: BorderSide(color: Colors.blue,width:2)),
                        ),
                      ),
                      const SizedBox(height: 10),
                      TextFormField(
                        controller : fullNameController,
                        validator: (value) {
                          if (value == null || value.isEmpty) {
                            return 'Champ obligatoire';
                          }
                          return null;
                        },
                        decoration: const InputDecoration(
                          prefixIcon: Icon(Icons.person_outline_outlined, color: Colors.black),
                          labelText: "nom complete",
                          labelStyle: TextStyle(
                              color: Colors.blue
                          ),
                          hintText: "nom complete",

                          border: OutlineInputBorder(),
                          focusedBorder: OutlineInputBorder(borderSide: BorderSide(color: Colors.blue,width:2)),
                        ),
                      ),
                      const SizedBox(height: 10),
                      TextFormField(
                        keyboardType: TextInputType.phone,
                        controller: phoneController,
                        validator: (value) {
                          if (value == null || value.isEmpty) {
                            return 'Champ obligatoire';
                          }

                          if (!RegExp(r'^(\+?213|0)(5|6|7)([0-9]{8})$').hasMatch(value)) {
                            return 'Numéro de téléphone non valide';
                          }
                          return null;
                        },
                        decoration: const InputDecoration(
                          prefixIcon: Icon(Icons.phone, color: Colors.black),
                          labelText: "Téléphone",
                          labelStyle: TextStyle(color: Colors.blue),
                          hintText: "Téléphone",
                          border: OutlineInputBorder(),
                          focusedBorder: OutlineInputBorder(
                            borderSide: BorderSide(color: Colors.blue, width: 2),
                          ),
                        ),
                      ),

                      const SizedBox(height: 10),

                      TextFormField(
                        controller : passwordController,
                        validator: (value) {
                          if (value == null || value.isEmpty) {
                            return 'Champ obligatoire';
                          }
                          if(value.length<5){
                            return 'le mot de pass et tres petit ';

                          }
                          return null;
                        },
                        decoration: const InputDecoration(
                          prefixIcon: Icon(Icons.fingerprint, color: Colors.black),
                          labelText: "Mot de passe",
                          labelStyle: TextStyle(
                              color: Colors.blue
                          ),
                          hintText: "Mot de passe",

                          border: OutlineInputBorder(),
                          focusedBorder: OutlineInputBorder(borderSide: BorderSide(color: Colors.blue,width:2 )),


                        ),
                      ),
                      const SizedBox(height: 10),

                      SizedBox(
                        width: double.infinity,
                        child: ElevatedButton(
                          onPressed: () {
                            if (formKey.currentState!.validate()) {
                       final db = DatabaseHelper();
                                    db
                                      .signup(Users(
                                        usrId: matriculeController.text,
                                         usrFullName: fullNameController.text,
                                            usrPhone: phoneController.text,
                                            usrPassword: passwordController.text
                                    ))
                                 .whenComplete(() {
                                      matriculeController.clear();
                                      fullNameController.clear();
                                      phoneController.clear();
                                      passwordController.clear();
                                     Navigator.push(
                                       context,
                                  MaterialPageRoute(
                                builder: (context) => const LoginPage()));
                                    });
                                 }
                            },


                          style: ElevatedButton.styleFrom(
                            foregroundColor: Colors.white,
                            backgroundColor: Colors.black,
                            shape: const RoundedRectangleBorder(),
                            side: const BorderSide(color: Colors.black),
                            padding: const EdgeInsets.symmetric(vertical: 20),
                          ),
                          child: Text("SIGN".toUpperCase()),
                        ),
                      ),
                      const SizedBox(height: 10),
                      Align(
                        alignment: Alignment.center,
                        child: TextButton(
                          onPressed: () {
                            Navigator.push(
                              context,
                              MaterialPageRoute(builder: (context) => const LoginPage()),
                            );
                          },
                          child: Text.rich(
                            TextSpan(
                              text: "vous avez déja un compte ? ",
                              style: Theme.of(context).textTheme.bodyLarge,
                              children: const [
                                TextSpan(
                                  text: "Se connecter",
                                  style: TextStyle(color: Colors.blue),
                                ),
                              ],
                            ),
                          ),
                        ),
                      ),
                    ],
                  ),
                ),

            ],
          ),
          ),
        ),
      ),
    );
  }
}