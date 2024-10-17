using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;

//MVC projesinin BundleConfig yapısını algılayabilmesi için içerisinde BundleCollection parametresi alan RegisterBundle adında bir static fonksiyon oluşturmamız gerekiyor
namespace _16122023_BundleConfig.App_Start
{
    // Oluşturulan BundleConfig class ını Global.asax ın içerisinde tanıtmamız gerekmektedir
    public class BundleConfig
    {
        public static void RegisterBundle(BundleCollection bundles)
        {
            BundleTable.EnableOptimizations= true;
            //Bu alanda kütüphane tanımlamaları yapılmaktadır

            //BundleConfig içerisinde script dosyaları ve style dosyaları için iki farklı tanımlama bulunmaktadır

            // ScriptBundle => Script dosyaları için kullanılır
            // StyleBundle => Style dosyaları için kullanılır
            bundles.Add(new StyleBundle("~/bundles/custom").Include("~/Assets/StyleSheet1.css"));
        }

    }
}