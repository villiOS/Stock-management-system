using System;//temel sistem fonksiyonları için gerekli library
using System.Collections.Generic; //liste tipinde olan veriler için gerekli library
using System.ComponentModel;
using System.Data; 
using System.Drawing; //ekrana çizim işlemleri için gerekli library
using System.Linq; // bu kullanılmadı, c# ta default olarak projeye ekleniyor
using System.Media; // ses çalma fonksiyonları için gerekli library
using System.Text; 
using System.Threading.Tasks; //paralel işlemler için gerekli library (bekleme fonksiyonu)
using System.Windows.Forms; // form ana elemanları için gerekli library

namespace WumpusApp
{
    public partial class MainFrm : Form
    {
        int[] karakterKoordinat = new int[2]; // karakterin konumunu(matris olarak) tutan değişken. ilk değeri x, 2.değeri y değeri
        int[] wumpusKoordinat = new int[2];// wumpusun konumunu(matris olarak) tutan değişken. ilk değeri x, 2.değeri y değeri
        int[] yeniWumpusKoordinat = new int[2];// wumpus hareket ettikten sonraki konumunu(matris olarak) tutan değişken. ilk değeri x, 2.değeri y değeri
        int[] altinKoordinat = new int[2];// altının konumunu(matris olarak) tutan değişken. ilk değeri x, 2.değeri y değeri
        int[] cukurKoordinat = new int[2];// cukurun konumunu(matris olarak) tutan değişken. ilk değeri x, 2.değeri y değeri
        Button[,] dizi = new Button[10, 10]; // ekrandaki 10x10 boyutundaki butonları tutan dizi
        
        //Bunlardan sadece karakter ekranda görünüyor. Diğerlinin visible özelliği false
        Image karakterImage = new Bitmap( "karakter.png" ); // karakter iconunu değişkene atama işlemi
        Image wumpusImage = new Bitmap( "wumpus.png" );// wumpus iconunu değişkene atama işlemi
        Image cukurImage = new Bitmap( "kuyu.png" );// cukur iconunu değişkene atama işlemi
        Image altinImage = new Bitmap( "altin.png" );// altin iconunu değişkene atama işlemi

        public MainFrm( )
        {
            Basla(); // ekran üzerindeki form elemanlarının çizimlerini yapan init fonksiyonu

            KarakterYerlesimleriYap(); // tüm karakterlerin yerleşimlerinin yapıldığı fonksiyon
        } //OK.
        private void Basla( )
        {
            InitializeComponent();
        } //OK.
        private void KarakterYerlesimleriYap( )
        {
            bool karakterKabul = false; 
            bool wumpusKabul = false;
            bool altinKabul = false;
            bool cukurKabul = false;

            int x = 0, y = 0;

            //Burada butonları matris gibi düşünerek bir diziye atıyoruz.
            #region Kareler

            dizi[0, 0] = btn00;
            dizi[0, 1] = btn01;
            dizi[0, 2] = btn02;
            dizi[0, 3] = btn03;
            dizi[0, 4] = btn04;
            dizi[0, 5] = btn05;
            dizi[0, 6] = btn06;
            dizi[0, 7] = btn07;
            dizi[0, 8] = btn08;
            dizi[0, 9] = btn09;
            dizi[1, 0] = btn10;
            dizi[1, 1] = btn11;
            dizi[1, 2] = btn12;
            dizi[1, 3] = btn13;
            dizi[1, 4] = btn14;
            dizi[1, 5] = btn15;
            dizi[1, 6] = btn16;
            dizi[1, 7] = btn17;
            dizi[1, 8] = btn18;
            dizi[1, 9] = btn19;
            dizi[2, 0] = btn20;
            dizi[2, 1] = btn21;
            dizi[2, 2] = btn22;
            dizi[2, 3] = btn23;
            dizi[2, 4] = btn24;
            dizi[2, 5] = btn25;
            dizi[2, 6] = btn26;
            dizi[2, 7] = btn27;
            dizi[2, 8] = btn28;
            dizi[2, 9] = btn29;
            dizi[3, 0] = btn30;
            dizi[3, 1] = btn31;
            dizi[3, 2] = btn32;
            dizi[3, 3] = btn33;
            dizi[3, 4] = btn34;
            dizi[3, 5] = btn35;
            dizi[3, 6] = btn36;
            dizi[3, 7] = btn37;
            dizi[3, 8] = btn38;
            dizi[3, 9] = btn39;
            dizi[4, 0] = btn40;
            dizi[4, 1] = btn41;
            dizi[4, 2] = btn42;
            dizi[4, 3] = btn43;
            dizi[4, 4] = btn44;
            dizi[4, 5] = btn45;
            dizi[4, 6] = btn46;
            dizi[4, 7] = btn47;
            dizi[4, 8] = btn48;
            dizi[4, 9] = btn49;
            dizi[5, 0] = btn50;
            dizi[5, 1] = btn51;
            dizi[5, 2] = btn52;
            dizi[5, 3] = btn53;
            dizi[5, 4] = btn54;
            dizi[5, 5] = btn55;
            dizi[5, 6] = btn56;
            dizi[5, 7] = btn57;
            dizi[5, 8] = btn58;
            dizi[5, 9] = btn59;
            dizi[6, 0] = btn60;
            dizi[6, 1] = btn61;
            dizi[6, 2] = btn62;
            dizi[6, 3] = btn63;
            dizi[6, 4] = btn64;
            dizi[6, 5] = btn65;
            dizi[6, 6] = btn66;
            dizi[6, 7] = btn67;
            dizi[6, 8] = btn68;
            dizi[6, 9] = btn69;
            dizi[7, 0] = btn70;
            dizi[7, 1] = btn71;
            dizi[7, 2] = btn72;
            dizi[7, 3] = btn73;
            dizi[7, 4] = btn74;
            dizi[7, 5] = btn75;
            dizi[7, 6] = btn76;
            dizi[7, 7] = btn77;
            dizi[7, 8] = btn78;
            dizi[7, 9] = btn79;
            dizi[8, 0] = btn80;
            dizi[8, 1] = btn81;
            dizi[8, 2] = btn82;
            dizi[8, 3] = btn83;
            dizi[8, 4] = btn84;
            dizi[8, 5] = btn85;
            dizi[8, 6] = btn86;
            dizi[8, 7] = btn87;
            dizi[8, 8] = btn88;
            dizi[8, 9] = btn89;
            dizi[9, 0] = btn90;
            dizi[9, 1] = btn91;
            dizi[9, 2] = btn92;
            dizi[9, 3] = btn93;
            dizi[9, 4] = btn94;
            dizi[9, 5] = btn95;
            dizi[9, 6] = btn96;
            dizi[9, 7] = btn97;
            dizi[9, 8] = btn98;
            dizi[9, 9] = btn99;
            #endregion

            //Karakter yerini rastgele atamak için kullanacağımız rastgele nesnesi
            Random karakterYeri = null;



            while ( !karakterKabul ) // OK.
            {
                karakterYeri = new Random();

                x = karakterYeri.Next( 0, 9 ); // 0-9 arasında rastgele bir sayı at. X değeri
                System.Threading.Thread.Sleep( 500 ); // yarım saniye bekle (500ms)
                y = karakterYeri.Next( 0, 9 ); // 0-9 arasında rastgele bir sayı at. Y değeri

                if ( x == 0 || x == 9 || y == 0 || y == 9 ) // x ve y değerleri kenarlarda mı?
                {
                    karakterKoordinat[0] = x;
                    karakterKoordinat[1] = y;
                    dizi[karakterKoordinat[0], karakterKoordinat[1]].Name = "Karakter"; //İcon üzerine karakter yazısı ekle
                    dizi[karakterKoordinat[0], karakterKoordinat[1]].Image = karakterImage; // ekrana karakter iconunu bastır
                    karakterKabul = true;
                }
            }



            while ( !wumpusKabul )
            {
                karakterYeri = new Random();
                x = karakterYeri.Next( 0, 9 );
                System.Threading.Thread.Sleep( 500 );
                y = karakterYeri.Next( 0, 9 );

                if ( x != 0 && x != 9 && y != 0 && y != 9 ) // matrisin kenarında değil mi? (matrisin kenarında başlamsın istiyoruz)
                {
                    wumpusKoordinat[0] = x;
                    wumpusKoordinat[1] = y;
                    dizi[wumpusKoordinat[0], wumpusKoordinat[1]].Name = "Wumpus";
                    //dizi[wumpusKoordinat[0], wumpusKoordinat[1]].Image = wumpusImage;
                    wumpusKabul = true;
                }
            }


            while ( !altinKabul )
            {
                karakterYeri = new Random();
                altinKoordinat[0] = karakterYeri.Next( 0, 9 );
                System.Threading.Thread.Sleep( 500 );
                altinKoordinat[1] = karakterYeri.Next( 0, 9 );

                if ( ( wumpusKoordinat[0] != altinKoordinat[0] && wumpusKoordinat[1] != altinKoordinat[1] ) || ( karakterKoordinat[0] != altinKoordinat[0] && karakterKoordinat[1] != altinKoordinat[1] ) ) // altın, karakterin ve wumpusun üzeindeyse tekrar koordinat hesapla
                {
                    dizi[altinKoordinat[0], altinKoordinat[1]].Name = "Altın";
                    //dizi[altinKoordinat[0], altinKoordinat[1]].Image = altinImage;
                    altinKabul = true;
                }
            }

            while ( !cukurKabul ) // OK.
            {
                karakterYeri = new Random();
                cukurKoordinat[0] = karakterYeri.Next( 0, 9 );
                System.Threading.Thread.Sleep( 500 );
                cukurKoordinat[1] = karakterYeri.Next( 0, 9 );

                if ( ( wumpusKoordinat[0] != cukurKoordinat[0] && wumpusKoordinat[1] != cukurKoordinat[1] ) || ( altinKoordinat[0] != cukurKoordinat[0] && altinKoordinat[1] != cukurKoordinat[1] ) || ( karakterKoordinat[0] != cukurKoordinat[0] && karakterKoordinat[1] != cukurKoordinat[1] ) ) // çukur, diğer elemanların üzerine dek gelmişse tekrar hesapla
                {
                    dizi[cukurKoordinat[0], cukurKoordinat[1]].Name = "Çukur";
                    //dizi[cukurKoordinat[0], cukurKoordinat[1]].Image = cukurImage;
                    cukurKabul = true;
                }
            }








        } // OK.
        private void IleriGit( )
        {
            CevreKontrol(); // çevresindeki karakterleri kontrol et
            if ( karakterKoordinat[0] != 0 ) // sol üs en köşeye gelmemişse (çünkü köşedeyse daha ileri gidemez)
            {
                //ileri hareket etme
                dizi[karakterKoordinat[0], karakterKoordinat[1]].Name = "";
                dizi[karakterKoordinat[0], karakterKoordinat[1]].Image = null;
                dizi[karakterKoordinat[0] - 1, karakterKoordinat[1]].Name = "Karakter";
                dizi[karakterKoordinat[0] - 1, karakterKoordinat[1]].Image = karakterImage;
                karakterKoordinat[0] = karakterKoordinat[0] - 1;
            }
            if ( karakterKoordinat[0] == altinKoordinat[0] && karakterKoordinat[1] == altinKoordinat[1] ) // altının üzerine gelmişse
            {
                //altını bulmuşsa oyun biter.
                WinnerSesi(); 
                this.KeyPreview = false; //klavye işlemlerini etkisizleştir. (çünkü oyun bitti)
                SonucEkran(); //ekranda sonucu göster
            }

        }// OK.
        private void SolaDon( )
        {
            CevreKontrol();// çevresindeki karakterleri kontrol et
            if ( karakterKoordinat[1] != 0 ) // en sola gelmemişse (çünkü en soldaysa daha sola gidemez)
            {
                //sola hareket et
                dizi[karakterKoordinat[0], karakterKoordinat[1]].Name = "";// eski yerini temizle
                dizi[karakterKoordinat[0], karakterKoordinat[1]].Image = null; // eski yerini temizle
                dizi[karakterKoordinat[0], karakterKoordinat[1] - 1].Name = "Karakter"; // yeni yerini ayarla
                dizi[karakterKoordinat[0], karakterKoordinat[1] - 1].Image = karakterImage;// yeni yerini ayarla
                karakterKoordinat[1] = karakterKoordinat[1] - 1; // yeni koordinatı ayarla
            }

            if ( karakterKoordinat[0] == altinKoordinat[0] && karakterKoordinat[1] == altinKoordinat[1] )//altını bulmuşsa
            {
                //altını bulmuşsa oyun biter.
                WinnerSesi();
                this.KeyPreview = false;//klavye işlemlerini etkisizleştir. (çünkü oyun bitti)
                SonucEkran();//ekranda sonucu göster

            }
        }  // OK.
        private void SagaDon( )
        {
            CevreKontrol();
            if ( karakterKoordinat[1] != 9 ) // en sağa gelmemişse (en sağdaysa daha sağa gidemez)
            {
                //sağa hareket et
                dizi[karakterKoordinat[0], karakterKoordinat[1]].Name = ""; // eski yerini temizle
                dizi[karakterKoordinat[0], karakterKoordinat[1]].Image = null; // eski yerini temizle
                dizi[karakterKoordinat[0], karakterKoordinat[1] + 1].Name = "Karakter";// yeni yerini ayarla
                dizi[karakterKoordinat[0], karakterKoordinat[1] + 1].Image = karakterImage;// yeni yerini ayarla
                karakterKoordinat[1] = karakterKoordinat[1] + 1;// yeni koordinatı ayarla
            }

            if ( karakterKoordinat[0] == altinKoordinat[0] && karakterKoordinat[1] == altinKoordinat[1] ) //altını bulmuşsa
            {
                WinnerSesi();
                this.KeyPreview = false;
                SonucEkran();

            }
        }  // OK.
        private void GeriGit( )
        {
            CevreKontrol();
            if ( karakterKoordinat[0] != 9 ) // en aşağıda değilse (çünkü en aşağıda ise daha aşağı gidemez)
            {
                dizi[karakterKoordinat[0], karakterKoordinat[1]].Name = ""; // eski yerini temizle
                dizi[karakterKoordinat[0], karakterKoordinat[1]].Image = null; // eski yerini temizle
                dizi[karakterKoordinat[0] + 1, karakterKoordinat[1]].Name = "Karakter";// yeni yerini ayarla
                dizi[karakterKoordinat[0] + 1, karakterKoordinat[1]].Image = karakterImage;// yeni yerini ayarla
                karakterKoordinat[0] = karakterKoordinat[0] + 1;// yeni koordinatı ayarla
            }

            if ( karakterKoordinat[0] == altinKoordinat[0] && karakterKoordinat[1] == altinKoordinat[1] )
            {
                WinnerSesi();
                this.KeyPreview = false;
                SonucEkran();

            }

        }  // OK.
        private void SonucEkran( )
        {
            MessageBox.Show( "Kazandınız !", "SONUÇ", MessageBoxButtons.OK ); // Ekrana kazandınız yazar
        }  // OK.
        private void CevreKontrol( )
        {
            string solUst = "", ust = "", sagUst = "", sol = "", orta = "", sag = "", solAlt = "", alt = "", sagAlt = "";
            List<string> cevre = new List<string>(); // 9x9 luk küçük matrisler oluşturcaz ve tam ortadaki kendisi olacak. Çevresini kontrol edecek , hangi karakter var diye
            

            try // aşağıdaki işlemi yapmayı dene. hata alırsan işlemi yapma
            {
                solUst = dizi[karakterKoordinat[0] - 1, karakterKoordinat[1] - 1].Name; // 9x9 luk matrisin sol üstünde olan karakteri bul ve sol üst değişkenine ata
            }
            catch ( Exception )
            {
            }



            try// aşağıdaki işlemi yapmayı dene. hata alırsan işlemi yapma
            {
                ust = dizi[karakterKoordinat[0], karakterKoordinat[1] - 1].Name;
            }
            catch ( Exception )
            {
            }


            try// aşağıdaki işlemi yapmayı dene. hata alırsan işlemi yapma
            {
                sagUst = dizi[karakterKoordinat[0] + 1, karakterKoordinat[1] - 1].Name;
            }
            catch ( Exception )
            {
            }


            try// aşağıdaki işlemi yapmayı dene. hata alırsan işlemi yapma
            {
                sol = dizi[karakterKoordinat[0] - 1, karakterKoordinat[1]].Name;
            }
            catch ( Exception )
            {
            }



            try// aşağıdaki işlemi yapmayı dene. hata alırsan işlemi yapma
            {
                sag = dizi[karakterKoordinat[0] + 1, karakterKoordinat[1]].Name;
            }
            catch ( Exception )
            {
            }


            try// aşağıdaki işlemi yapmayı dene. hata alırsan işlemi yapma
            {
                solAlt = dizi[karakterKoordinat[0] - 1, karakterKoordinat[1] + 1].Name;
            }
            catch ( Exception )
            {
            }


            try// aşağıdaki işlemi yapmayı dene. hata alırsan işlemi yapma
            {
                alt = dizi[karakterKoordinat[0], karakterKoordinat[1] + 1].Name;
            }
            catch ( Exception )
            {
            }


            try// aşağıdaki işlemi yapmayı dene. hata alırsan işlemi yapma
            {
                sagAlt = dizi[karakterKoordinat[0] + 1, karakterKoordinat[1] + 1].Name;
            }
            catch ( Exception )
            {
            }

            ///////////////////////////////////////////////////////////////////////////////

            // çevre değişkeni bir liste haline geliyor. Daha sonra bu liste kontrol edilecek. Hangi elemanlar var diye. Ona göre ses çıkacak
            cevre.Add( solUst ); // çevreye ekle -> sol üstü
            cevre.Add( ust );// çevreye ekle -> üstü
            cevre.Add( sagUst );// çevreye ekle -> sağ üstü
            cevre.Add( sol );// çevreye ekle -> solu
            cevre.Add( sag );// çevreye ekle -> sağı
            cevre.Add( solAlt );// çevreye ekle -> sol altı
            cevre.Add( alt );// çevreye ekle -> altı
            cevre.Add( sagAlt );// çevreye ekle -> sağ altı

            foreach ( var item in cevre ) // çevre listesi kontrol ediliyor
            {
                if ( item.Equals( "Wumpus" ) ) // eğer çevrede wumpus varsa
                {
                    WumpusSesi();
                }
                else if ( item.Equals( "Altın" ) )// eğer çevrede altın varsa
                {
                    AltinSesi();
                }
                else if ( item.Equals( "Çukur" ) )// eğer çevrede çukur varsa
                {
                    CukurSesi();
                }

            }




        } // OK.
        private void CukurSesi( )
        {
            SoundPlayer player = new SoundPlayer(); // ses çalması için gerekli nesne
            string path = "cukur.wav"; // sesin adresi/yolu
            player.SoundLocation = path; 
            player.Play(); //çal
            System.Threading.Thread.Sleep( 1000 ); // 1sn boyunca çal
            player.Stop();// sesi kapat
        } // OK.
        private void AltinSesi( )
        {
            SoundPlayer player = new SoundPlayer();// ses çalması için gerekli nesne
            string path = "altin.wav"; // sesin adresi/yolu
            player.SoundLocation = path;
            player.Play(); //play it
            System.Threading.Thread.Sleep( 1000 );// 1sn boyunca çal
            player.Stop();// sesi kapat
        } // OK.
        private void WumpusSesi( )
        {
            SoundPlayer player = new SoundPlayer();// ses çalması için gerekli nesne
            string path = "wumpus.wav"; // sesin adresi/yolu
            player.SoundLocation = path;
            player.Play(); //play it
            System.Threading.Thread.Sleep( 1000 );// 1sn boyunca çal
            player.Stop();// sesi kapat
        } // OK.
        private void WinnerSesi( )
        {
            SoundPlayer player = new SoundPlayer();
            string path = "win.wav"; // Müzik adresi
            player.SoundLocation = path;
            player.Play(); //play it
            System.Threading.Thread.Sleep( 1000 );
            player.Stop();
        }  // OK.
        private void GameOverSesi( )
        {
            SoundPlayer player = new SoundPlayer();
            string path = "gameOver.wav"; // Müzik adresi
            player.SoundLocation = path;
            player.Play(); //play it
            System.Threading.Thread.Sleep( 1000 );
            player.Stop();
        } // OK.
        private void GameOverEkran( )
        {
            MessageBox.Show( "Kaybettiniz !" );
        } // OK.
        private void WumpusHareketi( )
        {
            Random yonler = new Random();
            int x = 0, y = 0;

            //wupmpusun hareketi için rastgele bir komşu kare seçiliyor.
            x = yonler.Next( 1, 3 ); // x koordinatı
            System.Threading.Thread.Sleep( 500 ); // 0.5 sn bekle. Çünkü x ve y aynı gelebilir.
            y = yonler.Next( 1, 3 ); // y koordinatı
            try
            {

                if ( ( ( x - 2 ) >= 0 && ( y - 2 ) >= 0 ) && ( x - 2 ) <= 9 && ( y - 2 ) <= 9 ) // yeni üretilen x ve y koordinatları wumpusun koordinatına komşu ise
                {
                    // wumpusun yeni yere geçmesi
                    yeniWumpusKoordinat[0] = wumpusKoordinat[0] + ( x - 2 );
                    yeniWumpusKoordinat[1] = wumpusKoordinat[1] + ( y - 2 );

                  

                    wumpusKoordinat[0] = yeniWumpusKoordinat[0];
                    wumpusKoordinat[1] = yeniWumpusKoordinat[1];

                    
                }



            }
            catch ( Exception )
            {
            }





        }  
        private bool GameOverKontrol( )
        {
            if ( karakterKoordinat[0] == wumpusKoordinat[0] && karakterKoordinat[1] == wumpusKoordinat[1] ) // eğer karakter wumpusun üzerine geldiyse oyunu bitir.
                return true; // Oyun Sonu
            else
                return false; // Oyuna Devam
        } // OK. 
        private void MainFrm_KeyPress( object sender, KeyPressEventArgs e ) // OK.
        {
            if ( e.KeyChar == 'w' || e.KeyChar == 'W' ) // eğer w veya W'ya basılmışsa ileri
            {
                IleriGit();
                WumpusHareketi();
                if ( GameOverKontrol() )
                {
                    KeyPreview = false;
                    GameOverSesi();
                    GameOverEkran();
                }
            }
            else if ( e.KeyChar == 's' || e.KeyChar == 'S' ) //geri
            {
                GeriGit();
                WumpusHareketi();
                if ( GameOverKontrol() )
                {
                    KeyPreview = false;
                    GameOverSesi();
                    GameOverEkran();
                }
            }
            else if ( e.KeyChar == 'd' || e.KeyChar == 'D' ) //sağ
            {
                SagaDon();
                WumpusHareketi();
                if ( GameOverKontrol() )
                {
                    KeyPreview = false;
                    GameOverSesi();
                    GameOverEkran();
                }
            }
            else if ( e.KeyChar == 'a' || e.KeyChar == 'A' ) //sol
            {
                SolaDon();
                WumpusHareketi();
                if ( GameOverKontrol() )
                {
                    KeyPreview = false;
                    GameOverSesi();
                    GameOverEkran();
                }
            }
            else
                MessageBox.Show( "W->ileri \n A->sol \n S->geri \n D->sağ" ); // yanlış bir tuşa basılmışsa


        }


    }
}
