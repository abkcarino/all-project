
import 'package:engtpscanner/main.dart';
import 'package:flutter/material.dart';
import 'package:flutter/services.dart';
import 'package:engtpscanner/src/features/authentication/sqlite/sqlite.dart';
import 'package:get/get.dart';
import '../models/inventoryitem.dart';
import 'package:engtpscanner/src/features/authentication/screens/InventoryPage.dart';
import 'package:flutter_barcode_scanner/flutter_barcode_scanner.dart';

class MyHomePage extends StatefulWidget {
  const MyHomePage({Key? key}) : super(key: key);

  @override
  _MyHomePageState createState() => _MyHomePageState();
}

class _MyHomePageState extends State<MyHomePage> {
  final db = DatabaseHelper();
  String getTimeNow() {
    var now = DateTime.now();
    return "${now.year}-${now.month.toString().padLeft(2, '0')}-${now.day.toString().padLeft(2, '0')}";
  }

  int activestep = 0;
  TextEditingController lieu = TextEditingController();
  TextEditingController codelieu = TextEditingController();
  TextEditingController nomi = TextEditingController();
  TextEditingController codebare = TextEditingController();
  TextEditingController etati = TextEditingController();
  String? _selectedReg;
  String? _selectedSite;
  String? _selectedEtat;
  String? _selectedEtati;
  final List<String> _regs =[
    'Siège',
    'DRZ',
    'DRK',
    'DRM',
    'DRR',
    'Centre CSZ'
  ]; // Example options for TextField 1
  final List<String> Etats =[
    'Actif',
    'Non Actif',
    'En Travaux'
  ];
  final List<String> Etatsi =[
    'En bon état',
    'Endommagé',
    'Hors service'
  ];
  final Map<String,List<String>> _sites = {
    'Siège': [
      'Siège Reghaia(bloc administratif et annexes)',
      'logements astreintes(Reghaia) ',
      'Parc exterieur EGZIB',
      'Parc materiel  exterieur',
      'Logement PDG',
      'Terrain  Boudouaou El Bahri',
      'Camp de toile El Kerma',
      'Atelier de maintenance',
      'Parc transport',
      'SH HYDRA Rue du SAHARA',
      'SH  HYDRA  Chemin du reservoir',
      'SH Oued Smar',
      'Rails logistiques ROUIBA',
      'Atelier de soudage',
      'Atelier de préfabrication',
      'Laboratoire d essais mécanique',
      'Blaukaus de source radioactive',
      'Magasin investissements',
      'Magasin réforme',
      'Oued guitrini (Bouira)',
      'Port dAlger',
      'Cap djanet',
      'EL CNESE',
      'Parking SH Mostaganem',
      'Atelier de traitement thermique'
    ],
    'DRZ': [
      'Base DRZ',
      'Projet MEDGAZ ( Beni Saf )',
      'Projet Naftal ( Port ORAN )',
      'Camp de toile Benadelmalek Ramdane  ( MOSTAGANEM )',
      'GNL 1/Z',
      'GNL 2/Z',
      'GP1/Z',
      'GP2/Z',
      'CP1/Z',
      'DOP',
      'SORFERT',
      'Cimenterie ZAHANA',
      'Port ARZEW et Port BETHIOUA'
    ],
    'DRK': [
      'PORT SKIKDA',
      'Raffinerie RA1K aff 8336',
      'Base DRK Skikda',
      'Chantier GNL 1K Skikda',
      'Chantier SH/ RTE Skikda',
      'Chantier CP2K Skikda',
      'Chantier NAFTAL Bounouara EL KHROUB',
      'Chantier SH RTC Bejaia',
      'Chantier SH/ RTE(SCA SCB SCD SCC)  Biskra',
      'Logement DRK Skikda'
    ],
    'DRM': [
      'DRM',
      'DHR',
      '5 JUILLET',
      'MAREP',
      'LPG',
      'IRARA',
      'IN AMENAS',
      'TFT',
      'ALRAR',
      'OHANET TINHERT',
      'RHOUD NOUSS',
      'GASSI TOUIL',
      'OURHOUD',
      'EL MERK',
      'CAFC (MLE)',
      'BRN',
      'RAMA',
      'BRS',
      'PROJET HEH',
      'PROJET Z.CINA',
      'PROJETS LOCAUX',
      'PROJET TIDIKELT SUD',
      'DMI EPM IRARA',
      'DMI EPM BAGUEL',
      'DMI EPM BMS',
      'BASE TUBULAIRE',
      'PARC DOUBLE JOINTING',
      'PARC SABLAGE',
      'PARC FORASOL',
      'LOGEMENTS'
    ],
    'DRR': [
      'Base logistique DRR',
      'Atelier Genie civil  ALCIP + Parc sablage',
      'Base de vie 1er MAI',
      'Base de vie 5 Juillet  ( NACAP )',
      'Camp famillial+Parc D jointing',
      'Base de vie SBC',
      'Bloc administratif (réseau de collecte)',
      'Chantiers périphériques DRR ',
      'Base et chantiers Oued Noumer',
      'chantiers HBK',
      'Projet TOUAT GAZ',
      'Chantier Hassi ILATO- SBAA',
      'Projet SC3 & Base de vie',
      'Projet AHNET & Bases de vie',
      'Chantier Reggane'
    ],
    'Centre CSZ': ['Centre CSZ']
  };
  final GlobalKey<FormState> _formKey = GlobalKey<FormState>();
  final GlobalKey<FormState> _formKey1 = GlobalKey<FormState>();

  bool isFormFilled = false;
  @override
  void initState() {
    super.initState();
    db.initDB();
    codelieu.addListener(updateFormFilledState);
    nomi.addListener(updateFormFilledState);
    codebare.addListener(updateFormFilledState);
    lieu.addListener(updateFormFilledState);
    etati.addListener(updateFormFilledState);
  }

  bool checkIfAllFieldsFilled() {
    /*  print('Lieu: ${lieu.text}');
    print('Code Lieu: ${codelieu.text}');
    print('Codebare: ${codebare.text}');
    print('Nomi: ${nomi.text}');
    print('_selectedReg: $_selectedReg');
    print('_selectedSite: $_selectedSite');
    print('_selectedEtat: $_selectedEtat');
    print('_selectedEtati: $_selectedEtati');*/

    return lieu.text.isNotEmpty &&
        codelieu.text.isNotEmpty &&
        codebare.text.isNotEmpty &&
        nomi.text.isNotEmpty && _selectedReg != null && _selectedSite != null && _selectedEtat != null && _selectedEtati != null;
  }
  void updateFormFilledState() {
    setState(() {
      isFormFilled = checkIfAllFieldsFilled();
    });
  }

  bool checkIfAllFieldsP1Filled() {
    return lieu.text.isNotEmpty &&
        codelieu.text.isNotEmpty &&
        _selectedReg != null && _selectedSite != null && _selectedEtat != null;
  }


  Future<void> scanbarcode(TextEditingController controller) async {
    String scanres;
    scanres = await FlutterBarcodeScanner.scanBarcode("#ff6666", "Cancel", false, ScanMode.BARCODE);
    if (!mounted) return;
    if (scanres == '-1') {
      return;
    }
    setState(() {
      controller.text = scanres;
    });
  }
  void _openDropdown(
      List<String> options, Function(String?) onSelect) async {
    final String? selectedOption = await showDialog(
      context: context,
      builder: (BuildContext context) {
        return  AlertDialog(
          title: const Text('Select an option'),
          content: DropdownButton<String>(
            isExpanded: true,
            value: options.contains(_selectedSite) ? _selectedSite : null,
            items: options.map((String option) {
              return DropdownMenuItem<String>(
                value: option,
                child: Text(option),
              );
            }).toList(),
            onChanged: (String? newValue) {
              onSelect(newValue!); // Assertion here to handle nullable value
              Navigator.of(context).pop(newValue);
            },
          ),
        );
      },
    );

    if (selectedOption != null) {
      onSelect(selectedOption);
    }
  }
  @override
  Widget build(BuildContext context) {
    return Scaffold(
      appBar: AppBar(title: const Text('GTP Inventory Scanner'),
        automaticallyImplyLeading: false,
        actions: [
          IconButton(
            onPressed: () {
              final db = DatabaseHelper();
              db.Deconnecter();
              Navigator.pushReplacement(
                  context, MaterialPageRoute(builder: (context) => const MyApp()));
            },
            icon: const Icon(Icons.exit_to_app),
          ),
        ],
      ),
      body:Form(
        key: _formKey,
        child: Stepper(
        type: StepperType.horizontal,
        currentStep: activestep,
        steps: [
          Step(

            state: activestep <= 0 ? StepState.editing : StepState.complete,
            isActive: activestep >= 0,
            title: const Text('Info Bureau'),
            content: Form(
              key: _formKey1,
              child:Center(
              child: Column(
                children: [
                  TextFormField(
                    validator: (value) {
                      if (value == null || value.isEmpty) {
                        return 'champ oblegatoire';
                      }
                      return null;
                    },
                    readOnly: true,
                    decoration: const InputDecoration(
                      labelText: 'Region',
                      suffixIcon: Icon(Icons.arrow_drop_down),
                    ),
                    onTap: () => _openDropdown(_regs, (String? newValue) {
                      setState(() {
                        _selectedReg = newValue;
                        _selectedSite = null; // Reset site on change of region
                      });
                    }),
                    controller: TextEditingController(
                      text: _selectedReg ?? '',
                    ),
                  ),
                  const SizedBox(height: 12),
                  if (_selectedReg != null)
                    TextFormField(
                      validator: (value) {
                        if (value == null || value.isEmpty) {
                          return 'champ oblegatoire';
                        }
                        return null;
                      },
                      readOnly: true,
                      decoration: const InputDecoration(
                        labelText: 'Site',
                        suffixIcon: Icon(Icons.arrow_drop_down),
                      ),
                      onTap: () => _openDropdown(
                          _sites[_selectedReg!]!, (String? newValue) {
                        setState(() {
                          _selectedSite = newValue;
                        });
                      }),
                      controller: TextEditingController(
                        text: _selectedSite ?? '',
                      ),
                    ),
                  const SizedBox(height: 12),

                  TextFormField(
                    validator: (value) {
                      if (value == null || value.isEmpty) {
                        return 'champ oblegatoire';
                      }
                      return null;
                    },
                    controller: lieu,
                    decoration: const InputDecoration(
                      focusedBorder: OutlineInputBorder(
                        borderSide: BorderSide(color: Colors.blue),
                      ),
                      border: OutlineInputBorder(),
                      labelText: 'Lieu',
                      labelStyle: TextStyle(color: Colors.blue),
                    ),
                  ),
                  const SizedBox(height: 12),
                  TextFormField(
                    validator: (value) {
                      if (value == null || value.isEmpty) {
                        return 'champ oblegatoire';
                      }
                  if (value.length != 12 && !RegExp('^11.*[a-zA-Z]').hasMatch(value) ) {
                    return 'code-bare incorrect';

    }
                      return null;
                    },
                    controller: codelieu,

                    decoration:  InputDecoration(
                      focusedBorder: const OutlineInputBorder(
                        borderSide: BorderSide(color: Colors.blue),
                      ),
                      border:const OutlineInputBorder(),
                      labelText: 'Code Lieu',
                      labelStyle:const TextStyle(color: Colors.blue),
                      suffixIcon: IconButton(
                        onPressed: () => scanbarcode(codelieu),
                        icon:const Icon(Icons.qr_code),
                      ),
                    ),
                  ),
                  const SizedBox(height: 12),
                  TextFormField(
                    validator: (value) {
                      if (value == null || value.isEmpty) {
                        return 'champ oblegatoire';
                      }
                      return null;
                    },
                    readOnly: true,
                    decoration: const InputDecoration(
                      labelText: 'ETAT Bureau',
                      suffixIcon: Icon(Icons.arrow_drop_down),
                    ),
                    onTap: () => _openDropdown(Etats, (String? newValue) {
                      setState(() {
                        _selectedEtat = newValue;
                      });
                    }),
                    controller: TextEditingController(
                      text: _selectedEtat ?? '',
                    ),
                  ),const SizedBox(height: 12),
                ],
              ),
              ),
            ),
          ),
          Step(
            state: activestep <= 1 ? StepState.editing : StepState.complete,
            isActive: activestep >= 1,
            title: const Text('Info Invest'),
            content: Center(
              child: Column(
                children: [
                  TextFormField(
                    validator: (value) {
                      if (value == null || value.isEmpty) {
                        return 'champ oblegatoire';
                      }
                      if (value.length != 12 && !RegExp('^11.*[a-zA-Z]').hasMatch(value) ) {
                        return 'code-bare incorrect';

                      }
                      return null;
                    },
                    controller: codebare,
                    decoration: InputDecoration(
                      focusedBorder:const OutlineInputBorder(
                        borderSide: BorderSide(color: Colors.blue),
                      ),
                      border:const OutlineInputBorder(),
                      labelText: 'Codebare',
                      labelStyle:const TextStyle(color: Colors.blue),
                      suffixIcon: IconButton(
                        onPressed: () => scanbarcode(codebare),
                        icon:const Icon(Icons.qr_code),
                      ),
                    ),
                  ),
                  const SizedBox(height: 12),
                  TextFormField(
                    validator: (value) {
                      if (value == null || value.isEmpty) {
                        return 'champ oblegatoire';
                      }
                      return null;
                    },
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
                  const SizedBox(height: 12),
                  TextFormField(
                    validator: (value) {
                      if (value == null || value.isEmpty) {
                        return 'champ oblegatoire';
                      }
                      return null;
                    },
                    readOnly: true,
                    decoration: const InputDecoration(
                      labelText: 'ETAT investissement',
                      suffixIcon: Icon(Icons.arrow_drop_down),
                    ),
                    onTap: () => _openDropdown(Etatsi, (String? newValue) {
                      setState(() {
                        _selectedEtati = newValue;
                        etati.text= newValue ?? '';
                      });
                    }),
                    controller: TextEditingController(
                      text: _selectedEtati ?? '',
                    ),
                  ), const SizedBox(height: 12),

                ],
              ),
            ),
          ),
        ],
        onStepContinue: () {
          if (activestep < 1) {
            activestep += 1;
          }
          setState(() {});
        },
        onStepCancel: () {
          if (activestep == 0) {
            return;
          }
          activestep -= 1;
          setState(() {});
        },
        controlsBuilder: (BuildContext context, ControlsDetails details) {
          return Row(
            mainAxisAlignment: MainAxisAlignment.end,
            children: <Widget>[
              Container(
                decoration: BoxDecoration(
                  borderRadius: BorderRadius.circular(10),
                  color: Colors.blue,
                ),
                child: TextButton(
                  onPressed: details.onStepCancel,
                  child: const Text('Previous', style: TextStyle(color: Colors.white)),
                ),
              ),
              const SizedBox(width: 10),
              Container(
                decoration: BoxDecoration(
                  borderRadius: BorderRadius.circular(10),
                  color: Colors.blue,
                ),
                child: TextButton(
                  onPressed: () {
                    if (_formKey1.currentState!.validate()) {
                     if (details.onStepContinue != null) {
                     if (checkIfAllFieldsP1Filled()) {
                           details.onStepContinue!();
          }
          }
          }
                  },
                  child: const Text('Next', style: TextStyle(color: Colors.white)),
                ),
              ),
              const SizedBox(width: 10),
              Container(
                decoration: BoxDecoration(
                  borderRadius: BorderRadius.circular(10),
                  color: isFormFilled ? Colors.blue : Colors.grey,
                ),
                child: TextButton(
                  onPressed: () async {
                    if (_formKey.currentState!.validate()) {
          await onPressedConfirm();
          ScaffoldMessenger.of(context).showSnackBar(
          const SnackBar(content: Text('Saved successfully')),
          );
          }
                  },
                  child: const Text('Confirm', style: TextStyle(color: Colors.white)),
                ),
              ),
            ],
          );
        },
      ),
      ),
      floatingActionButton: FloatingActionButton(
        onPressed: () {
          final db = DatabaseHelper();
          db.initDB();
          Navigator.push(
            context,
            MaterialPageRoute(builder: (context) => const InventoryPage()),
          );
        },
        backgroundColor: Colors.blue,
        child: const Icon(Icons.storage, color: Colors.white),
      ),
    );
  }

  Future<void> onPressedConfirm() async {
    final db = DatabaseHelper();

    if (isFormFilled) {
      final selectedReg = _selectedReg  ;
      final selectedSite = _selectedSite;
      final selectedEtat = _selectedEtat;
      final selectedEtati = _selectedEtati;

      if (selectedReg != null && selectedSite != null && selectedEtat != null && selectedEtati != null) {
        final item = InventoryItem(
            REG: selectedReg.toString(),
            SITE: selectedSite.toString(),
            LIEU: lieu.text,
            CDLIEU: codelieu.text,
            ETAT: selectedEtat.toString() ,
            NOMI: nomi.text,
            CODEI: codebare.text,
            ETATI: selectedEtati.toString(),
            usrId: db.getusrId().toString(),
            date: getTimeNow()
        );
        await db.insertInventoryItem(item);
        // Clear text fields after storing data
        lieu.clear();
        nomi.clear();
        codelieu.clear();
        codebare.clear();
      }
    }
  }
}