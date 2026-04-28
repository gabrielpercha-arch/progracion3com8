using System;
using System.Collections.Generic; 
using DesafioProgramacion; 

namespace DesafioProgramacion
{
    
    public enum TipoCuenta
    {
        Ahorro,
        Corriente
    }

    
    public class CuentaBancaria
    {
        private decimal _saldo;
        private TipoCuenta _tipoCuenta;
        private List<string> _historialTransacciones;

        public CuentaBancaria(decimal saldoInicial, TipoCuenta tipo)
        {
            if (saldoInicial < 0)
            {
                throw new ArgumentException("El saldo inicial no puede ser negativo.");
            }
            _saldo = saldoInicial;
            _tipoCuenta = tipo;
            _historialTransacciones = new List<string>();
            _historialTransacciones.Add($"Cuenta creada con saldo inicial: {saldoInicial:C}");
        }

        public decimal Saldo => _saldo; 

        public IReadOnlyList<string> HistorialTransacciones => _historialTransacciones.AsReadOnly(); 

        public void Depositar(decimal monto)
        {
            if (monto <= 0)
            {
                throw new ArgumentException("El monto a depositar debe ser mayor que cero.");
            }
            _saldo += monto;
            _historialTransacciones.Add($"Depósito de {monto:C}. Saldo actual: {_saldo:C}");
            Console.WriteLine($"Depósito exitoso: {monto:C}. Nuevo saldo: {_saldo:C}"); 
        }

        public void Retirar(decimal monto)
        {
            if (monto <= 0)
            {
                throw new ArgumentException("El monto a retirar debe ser mayor que cero.");
            }
            if (_saldo < monto)
            {
                throw new InvalidOperationException("Saldo insuficiente para realizar el retiro.");
            }
            _saldo -= monto;
            _historialTransacciones.Add($"Retiro de {monto:C}. Saldo actual: {_saldo:C}");
            Console.WriteLine($"Retiro exitoso: {monto:C}. Nuevo saldo: {_saldo:C}");
        }

        public void CalcularInteresMensual()
        {
            decimal interesCalculado = 0;
            if (_tipoCuenta == TipoCuenta.Ahorro)
            {
                interesCalculado = _saldo * 0.03m; // 3%
            }
            
            if (interesCalculado > 0)
            {
                _saldo += interesCalculado;
                _historialTransacciones.Add($"Interés mensual aplicado: {interesCalculado:C}. Saldo actual: {_saldo:C}");
                Console.WriteLine($"Interés mensual aplicado: {interesCalculado:C}. Nuevo saldo: {_saldo:C}"); 
            } else {
                 _historialTransacciones.Add($"No se aplicó interés mensual. Saldo actual: {_saldo:C}");
                 Console.WriteLine($"No se aplicó interés mensual. Saldo actual: {_saldo:C}"); 
            }
        }
    }

    
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Iniciando simulación bancaria...");

            
            CuentaBancaria miCuentaAhorro = new CuentaBancaria(1000m, TipoCuenta.Ahorro);
            Console.WriteLine($"\nSaldo inicial de la cuenta de ahorro: {miCuentaAhorro.Saldo:C}");

            
            miCuentaAhorro.Depositar(200m);
            miCuentaAhorro.Retirar(150m);
            miCuentaAhorro.CalcularInteresMensual();

            Console.WriteLine($"Saldo final de la cuenta de ahorro: {miCuentaAhorro.Saldo:C}");
            Console.WriteLine("Historial de transacciones:");
            foreach (var transaccion in miCuentaAhorro.HistorialTransacciones)
            {
                Console.WriteLine($"- {transaccion}");
            }

            
            try
            {
                miCuentaAhorro.Retirar(5000m); 
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine($"\nError al retirar: {ex.Message}");
            }

            Console.WriteLine("Simulación bancaria finalizada.");
        }
    }
}