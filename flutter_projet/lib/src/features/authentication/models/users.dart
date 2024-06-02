class Users {
  final String usrId;
  final String? usrFullName;
  final String? usrPhone;
  final String usrPassword;
  final int? usrType;

  Users({
    required this.usrId,
     this.usrFullName,
     this.usrPhone,
    required this.usrPassword,
    this.usrType,
  });

  factory Users.fromMap(Map<String, dynamic> json) => Users(
    usrId: json["usrId"],
    usrFullName: json["usrFullName"],
    usrPhone : json["usrPhone"],
    usrPassword: json["usrPassword"],
    usrType: json["usrType"]
  );

  Map<String, dynamic> toMap() => {
    "usrId": usrId,
    "usrName": usrFullName,
    "usrPhone" : usrPhone,
    "usrPassword": usrPassword,
    "usrType":usrType
  };
}