class InventoryItem {
  final String REG;
  final String SITE;
  final String LIEU;
  final String CDLIEU;
  final String ETAT;
  final String NOMI;
  final String CODEI;
  final String ETATI;
  final String usrId;
  final String date;
  /// Constructs an instance of [InventoryItem].
  InventoryItem({
    required this.REG,
    required this.SITE,
    required this.LIEU,
    required this.CDLIEU,
    required this.ETAT,
    required this.NOMI,
    required this.CODEI,
    required this.ETATI,
    required this.usrId,
    required this.date
  });

  /// Creates an instance of [InventoryItem] from a map (typically used for JSON deserialization).
  factory InventoryItem.fromMap(Map<String, dynamic> json) {
    return InventoryItem(
      REG: json["REG"],
      SITE: json["SITE"],
      LIEU: json["LIEU"],
      CDLIEU: json["CDLIEU"],
      ETAT: json["ETAT"],
      NOMI: json["NOMI"],
      CODEI: json["CODEI"],
      ETATI: json["ETATI"],
      usrId: json["usrId"],
      date: json["date"],
    );
  }

  /// Converts an instance of [InventoryItem] to a map (typically used for JSON serialization).
  Map<String, dynamic> toMap() {
    return {
      "REG": REG,
      "SITE": SITE,
      "LIEU": LIEU,
      "CDLIEU": CDLIEU,
      "ETAT":ETAT,
      "NOMI": NOMI,
      "CODEI": CODEI,
      "ETATI":ETATI,
      "usrId": usrId,
      "date":date
    };
  }
}
