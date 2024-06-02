import 'package:engtpscanner/src/features/authentication/screens/app_page.dart';
import 'package:flutter/material.dart';
import 'package:engtpscanner/src/features/authentication/screens/sign_page.dart';

import 'package:engtpscanner/src/features/authentication/sqlite/sqlite.dart';
import '../models/users.dart';


class LoginPage extends StatefulWidget {
  const LoginPage({super.key});

  @override
  State<LoginPage> createState() => _LoginPageState();
}

class _LoginPageState extends State<LoginPage> {
  final  matriculeController = TextEditingController();
  final  passwordController = TextEditingController();

  bool _passwordVisible = false;

  final formKey = GlobalKey<FormState>();

  bool isLoginTrue = false;

  final db = DatabaseHelper();

  //Now we should call this function in login button
  login() async {
    var response = await db
        .login(Users(usrId: matriculeController.text, usrPassword: passwordController.text));
    if (response == true) {

      if (!mounted)return;

      Navigator.pushReplacement(
          context, MaterialPageRoute(builder: (context) => const MyHomePage()));
    } else {
      //If not, true the bool value to show error message
      setState(() {
        isLoginTrue = true;
      });
    }
  }
  @override
  Widget build(BuildContext context) {
    var size = MediaQuery.of(context).size;

    return Scaffold(
      body: SingleChildScrollView(
        child: Container(
          padding: const EdgeInsets.all(30),
  child:  Form(
    key: formKey,
          child: Column(
            crossAxisAlignment: CrossAxisAlignment.start,
            children: [
              Image(image: const AssetImage('assets/images/welcome_image1.png'), height: size.height * 0.3),
              const SizedBox(height: 10),
              Text("Bienvenue", style: Theme.of(context).textTheme.displayMedium),
              Text("Connectez-vous pour accéder à engtp scanner", style: Theme.of(context).textTheme.bodyLarge),

              Container(
                  padding: const EdgeInsets.symmetric(vertical: 20),
                  child: Column(
                    crossAxisAlignment: CrossAxisAlignment.start,
                    children: [
                      TextFormField(
                        controller : matriculeController,
                        keyboardType: TextInputType.number,
                        validator: (value) {
                          if (value == null || value.isEmpty) {
                            return 'Champ obligatoire';
                          }
                          return null;
                        },
                        decoration: const InputDecoration(
                          prefixIcon: Icon(Icons.person_outline, color: Colors.black),
                          labelText: "Matricule",
                          labelStyle: TextStyle(color: Colors.blue),
                          hintText: "Entrez votre matricule",
                          border: OutlineInputBorder(),
                          focusedBorder: OutlineInputBorder(borderSide: BorderSide(color: Colors.blue, width: 2)),
                        ),
                      ),
                      const SizedBox(height: 10),
                      TextFormField(
                        controller : passwordController,
                        validator: (value) {
                          if (value == null || value.isEmpty) {
                            return 'Champ obligatoire';
                          }
                          return null;
                        },
                        obscureText: !_passwordVisible,

                        decoration: InputDecoration(
                          prefixIcon: const Icon(Icons.fingerprint, color: Colors.black),
                          labelText: "Mot de passe",
                          labelStyle: const TextStyle(color: Colors.blue),
                          hintText: "Entrez votre mot de passe",
                          border: const OutlineInputBorder(),
                          focusedBorder: const OutlineInputBorder(borderSide: BorderSide(color: Colors.blue, width: 2)),
                          suffixIcon: IconButton(
                            icon: Icon(_passwordVisible ? Icons.visibility : Icons.visibility_off, color: Colors.black),
                            onPressed: () {
                              setState(() {
                                _passwordVisible = !_passwordVisible;
                              });
                            },
                          ),
                        ),
                      ),
                      const SizedBox(height: 10),

                      SizedBox(
                        width: double.infinity,
                        child: ElevatedButton(
                          onPressed: () async {
                            if (formKey.currentState!.validate()) {
                              await db.Connecter(Users(usrId: matriculeController.text, usrPassword: passwordController.text));
                              login();
                              matriculeController.clear();
                              passwordController.clear();
                            }
                          },
                          style: ElevatedButton.styleFrom(
                            foregroundColor: Colors.white,
                            backgroundColor: Colors.black,
                            shape: const RoundedRectangleBorder(),
                            side: const BorderSide(color: Colors.black),
                            padding: const EdgeInsets.symmetric(vertical: 20),
                          ),
                          child: Text("LOGIN".toUpperCase()),
                        ),
                      ),
                      const SizedBox(height: 10),
                      Align(
                        alignment: Alignment.center,
                        child: TextButton(
                          onPressed: () {
                            Navigator.push(
                              context,
                              MaterialPageRoute(builder: (context) => const SignPage()),  // Corrected class name
                            );
                          },
                          child: Text.rich(
                            TextSpan(
                              text: "Je n'ai pas de compte ? ",
                              style: Theme.of(context).textTheme.bodyLarge,
                              children: const [
                                TextSpan(
                                  text: "S'inscrire",
                                  style: TextStyle(color: Colors.blue),
                                ),
                              ],
                            ),
                          ),

                        ),
                      ),
                      isLoginTrue
                          ? const Text(
                        "Username or passowrd is incorrect",
                        style: TextStyle(color: Colors.red),
                      )
                          : const SizedBox(),
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
