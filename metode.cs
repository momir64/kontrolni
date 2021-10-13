using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

//Dobija tabelu iz baze podataka i pravi listu objekata
//gde svaki red tabele predstavlja novi objekat
public static List<T> GetList() {
    var lista = new List<T>();

    DataTable dataTable = new DataTable();
    SqlCommand komanda = Konekcija.GetCommand();
    SqlDataAdapter adapter = new SqlDataAdapter(komanda);
    komanda.CommandText = "ImeProcedure";
    
    try {
        komanda.Connection.Open();
        adapter.Fill(dataTable);

        if (dataTable.Rows.Count < 1)
            throw new Exception("Tabela je prazna");

        foreach (DataRow row in dataTable.Rows) {
            var Item = new T();

            /*Dodavanje vrednosti*/

            lista.add(Item);
        }
    }
    catch (Exception e) {
        Console.WriteLine(e.Message);
    }

    return lista;
}

//Ispisuje listu objekata
public static void ShowList(List<T> list) {
    foreach (var item in list)
        Console.WriteLine(item);
}

//Format ispisa objekat kao red tabele
public override string ToString() {
    return string.Format("{0, -2}| {1, -20}| {2, -20} ... {n, -20}", param1, param2, param3, ... paramn);
}

//Pozivanje procedure sa parametrima
public static void OpisnoImeMetode(object params) {
    DataTable dataTable = new DataTable();
    SqlCommand komanda = Konekcija.GetCommand();
    SqlDataAdapter adapter = new SqlDataAdapter(komanda);

    komanda.CommandText = "imeProcedure";
    komanda.Parameters.AddWithValue("@param1", param1);
    komanda.Parameters.AddWithValue("@param2", param2);
    komanda.Parameters.AddWithValue("@param3", param3);
    komanda.Parameters.AddWithValue("@paramn", paramn);

    try {
        //Izvrsavanje komande i cuvanje rezultate ako postoje
        komanda.Connection.Open();
        adapter.Fill(dataTable);
        /*Operacije na podacima ako ima nekih*/
    }
    catch (Exception e) {
        Console.WriteLine(e.Message);
    }

    return /*nesto ili nista zavisi od tipa metode*/;
}
