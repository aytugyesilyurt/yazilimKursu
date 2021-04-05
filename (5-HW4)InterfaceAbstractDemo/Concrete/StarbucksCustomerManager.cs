using System;
using System.Collections.Generic;
using System.Text;
using _5_HW4_InterfaceAbstractDemo.Abstract;
using _5_HW4_InterfaceAbstractDemo.Entities;

namespace _5_HW4_InterfaceAbstractDemo.Concrete
{
    public class StarbucksCustomerManager : BaseCustomerManager
    {
        // Dependency Injection ( amacı: starbucks nesnesi çağırıldığında StarbucksCustomerManager 
        private ICustomerCheckService _customerCheckService;

        // concreate blok
        public StarbucksCustomerManager(ICustomerCheckService customerCheckService)
        {
            _customerCheckService = customerCheckService;
        }

        public override void Save(Customer customer)
        {
            // KAYIT YAPMA OPERASYONU İÇİN MERNİS KONTROLÜNDEN SONRA GERÇEK KİŞİ BİLGİLERİ VARSA KAYDEDER YOKSA HATA VERİR
            if (_customerCheckService.CheckIfRealPerson(customer))
            {
                base.Save(customer);
            }

            //throw new Exception("Kişi bilgileri yanlıştır!");

            else
            {
                Console.WriteLine("KİŞİ BİLGİLERİ YANLIŞTIR!");
            }
        }

        
    }
}
