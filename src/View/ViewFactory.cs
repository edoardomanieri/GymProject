using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ViewProject.View
{
    public class ViewFactory
    {
            private static Dictionary<string, UserControl> _viste = new Dictionary<string, UserControl>();

            public static UserControl GetView(string nomeView)
            {
                if (!_viste.ContainsKey(nomeView))
                {
                    UserControl view = CreateView(nomeView);
                    if (view != null)
                        _viste[nomeView] = view;
                }
                return _viste[nomeView];
            }

            private static UserControl CreateView(string nomeView)
            {
                switch (nomeView)
                {
                    case "SchermataAutenticazioneView":

                        return new SchermataAutenticazioneView();

                    case "CreaSchedaAutomaticaView":

                        return new CreaSchedaAutomaticaView();
                    case "SchermataPrincipaleView":

                        return new SchermataPrincipaleView();
                    case "CreaAccountView":
                        
                        return new CreaAccountView();
                    case "CreaSchedaManualeView":
                        
                        return new CreaSchedaManualeView();
                    case "ProfiloView":
                        
                        return new ProfiloView();
                    case "ProgressiView":

                        return new ProgressiView();
                    case "VideoView":

                        return new VideoView();

                default: return null;
                }
            }

        }
    }

