
import 'package:flutter/material.dart';
import 'package:engtpscanner/src/features/authentication/screens/Login_page.dart';
import 'package:engtpscanner/src/features/authentication/screens/Sign_page.dart';



void main() {
  runApp(const MyApp());
}

class MyApp extends StatelessWidget {
  const MyApp({super.key});

  // This widget is the root of your application.
  @override
  Widget build(BuildContext context) {
    return const MaterialApp(
      debugShowCheckedModeBanner: false,
      home:  AppHome(),
    );
  }
}
class AppHome extends StatelessWidget{
  @override
  const AppHome({super.key});
  @override
  Widget build(BuildContext context){
    var height =MediaQuery.of(context).size.height;
    return Scaffold(
body: Container(
  padding: const EdgeInsets.all(30),

child: Column(
  mainAxisAlignment: MainAxisAlignment.spaceEvenly,

  children: [
    Container(
      decoration: const BoxDecoration(
        border: Border(
          left: BorderSide(
            width: 30,
            color: Colors.white,
          ),
        ),
      ),
      child:  Image(image: const AssetImage('assets/images/welcome_image1.png'),height: height*0.5,),
    ),

   Column(
     children: [
       Text("Bienvenue sur ENGTP SCANNER" ,style: Theme.of(context).textTheme.displaySmall,textAlign: TextAlign.center),
       Text("engtp scanner vous offre une expérience utilisateur intuitive pour"
           " enregistrer et suivre en temps réel tous vos investissements",style:  Theme.of(context).textTheme.bodyLarge,textAlign: TextAlign.center,),
     ],
   ),

    Row(
      children: [
       Expanded(child: OutlinedButton(
         //  onPressed: () => Get.to(() => const Login_page()),
           onPressed: () {
             Navigator.push(
               context,
               MaterialPageRoute(builder: (context) => const LoginPage()),
             );
           },
           style: OutlinedButton.styleFrom(
             foregroundColor: Colors.black,
             shape: const RoundedRectangleBorder(),
             side: const BorderSide(color: Colors.black),
             padding: const EdgeInsets.symmetric(vertical: 20)
           ),
           child: Text("Login".toUpperCase())
       ),) ,
        const SizedBox(width: 10,),
        Expanded(child: ElevatedButton(
            onPressed: (){
              Navigator.push(
                context,
                MaterialPageRoute(builder: (context) => const SignPage()),
              );
            },
            style: ElevatedButton.styleFrom(
                foregroundColor: Colors.white,
                backgroundColor: Colors.black,
                shape: const RoundedRectangleBorder(),
                side: const BorderSide(color: Colors.black),
                padding: const EdgeInsets.symmetric(vertical: 20)
            ),

          child:Text("sign".toUpperCase())
        ),)
      ],
    )
  ],
) ,
),
    );
  }

  }




