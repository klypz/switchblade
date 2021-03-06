﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using Klypz.Switchblade.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klypz.Switchblade.Extensions.Tests
{
    [TestClass()]
    public class EnumerableExtensionTests
    {
        [TestMethod()]
        public void PaginationTest()
        {
            List<string> stList = new List<string>()
            {
"Lorem ipsum dolor sit amet, consectetur adipiscing elit.",
"Duis eleifend erat ut lorem cursus pulvinar.",
"Curabitur dignissim tellus et eros sagittis, a malesuada erat imperdiet.",
"Phasellus vitae ex fringilla, ornare ipsum nec, condimentum enim.",
"Ut at nisi sed metus suscipit vehicula eu sit amet lacus.",
"Mauris pharetra lectus eu mauris laoreet, at placerat ex pharetra.",
"Cras at elit et nibh vestibulum posuere.",
"Cras aliquam velit egestas, porta mauris eget, consequat enim.",
"Curabitur eget justo a lectus ornare elementum.",
"Ut laoreet nisl at scelerisque fringilla.",
"Ut cursus ex malesuada sodales molestie.",
"Nunc nec nulla at enim cursus sagittis at et nunc.",
"Nullam feugiat nisi nec efficitur eleifend.",
"Praesent finibus velit eu metus finibus, vitae aliquet lorem varius.",
"In ut tellus ac mauris dignissim porttitor.",
"Duis et neque et magna tincidunt porta.",
"Pellentesque tincidunt mauris sed sem convallis ultrices.",
"Quisque suscipit magna fermentum, dapibus felis eget, sagittis sapien.",
"Nullam imperdiet lacus sed turpis faucibus posuere.",
"Nam volutpat turpis eu pretium euismod.",
"Donec interdum nibh a justo interdum, vitae egestas neque posuere.",
"Morbi porttitor quam sit amet diam consequat, id finibus nunc auctor.",
"Praesent in enim sit amet neque imperdiet eleifend.",
"Sed posuere orci ac urna euismod ultrices.",
"Donec a nisi vitae augue pretium mollis et non ipsum.",
"Mauris in diam varius, imperdiet metus eget, auctor tellus.",
"Ut aliquam magna ac viverra aliquam.",
"In malesuada dolor elementum nibh maximus facilisis.",
"Aliquam auctor nulla quis quam placerat, eget vulputate orci rutrum.",
"Etiam posuere ipsum vel urna sodales ornare.",
"Morbi viverra urna eu rhoncus vestibulum.",
"Nam consectetur diam in nisl volutpat, sed bibendum ligula varius.",
"Duis eleifend sapien nec nulla volutpat, ac sagittis nunc ullamcorper.",
"Phasellus auctor massa eu fermentum ullamcorper.",
"Nunc laoreet nulla et lectus ultricies, et porttitor sem posuere.",
"Etiam dictum mi vitae dolor tincidunt sagittis.",
"Mauris et leo interdum, molestie arcu a, laoreet erat.",
"Integer venenatis mi ut eros mattis ultricies.",
"Sed malesuada ipsum sed nulla pharetra, ut tempus orci posuere.",
"Sed auctor augue vel mi ultricies, id sagittis augue vehicula.",
"Sed at orci vestibulum lacus molestie interdum ac et purus.",
"Fusce et ante ac risus egestas gravida.",
"Etiam ac ipsum vulputate, consectetur sem hendrerit, tempus erat.",
"Etiam scelerisque ligula ut neque vulputate elementum.",
"Vivamus ultrices turpis nec elit scelerisque consequat.",
"Proin malesuada elit sed odio molestie iaculis.",
"Donec aliquam risus eu quam efficitur, eget fermentum risus mollis.",
"Duis dictum nulla vel diam placerat molestie.",
"Nam semper purus sed risus euismod hendrerit.",
"Fusce semper massa congue, euismod mauris a, gravida ipsum.",
"Donec lacinia ex eget nunc fermentum, nec gravida purus feugiat.",
"Donec tincidunt leo id tortor ornare, quis hendrerit magna imperdiet.",
"Nunc tincidunt sem quis massa tincidunt, eget suscipit sapien feugiat.",
"Duis fringilla sem in nunc tincidunt, id luctus quam tempor.",
"Proin efficitur erat ac enim rhoncus, sit amet condimentum ligula vehicula.",
"Nullam ultricies neque non congue commodo.",
"Aliquam rhoncus elit et libero pellentesque, ac mollis dolor pharetra.",
"Vestibulum eget est at leo maximus blandit ut nec sem.",
"Mauris finibus orci et scelerisque laoreet.",
"Mauris interdum nisl et felis hendrerit, vitae sollicitudin lectus congue.",
"Ut sed libero sagittis, laoreet nibh quis, consectetur velit.",
"Maecenas auctor nunc eget eleifend fringilla.",
"Suspendisse commodo libero a erat porttitor condimentum.",
"Pellentesque vehicula quam at porttitor pulvinar.",
"Praesent ac ante in ipsum malesuada fermentum.",
"Nunc congue lorem vitae magna consectetur ultricies.",
"Nam tempor tortor in iaculis gravida.",
"Praesent eget lacus a ipsum varius porttitor.",
"Ut sit amet ante eget ligula iaculis dignissim non quis sem.",
"Aenean bibendum purus in commodo tincidunt.",
"Ut consequat quam vitae massa placerat interdum.",
"Pellentesque mollis lacus non ex condimentum hendrerit.",
"Sed fermentum metus dapibus maximus imperdiet.",
"Nunc at sapien at tellus ultricies pharetra.",
"Cras volutpat justo ac molestie pellentesque.",
"Donec nec odio finibus, maximus ante id, auctor nisl.",
"Sed hendrerit lacus quis enim luctus rhoncus.",
"Nulla rhoncus elit et vulputate rutrum.",
"Duis at magna eu dui ultrices aliquet.",
"Cras in odio convallis augue laoreet bibendum nec non nunc.",
"Donec in arcu varius, cursus neque non, scelerisque sem.",
"Cras a sem gravida, faucibus sapien at, dignissim nulla.",
"Nulla quis quam sit amet dolor fermentum gravida.",
"Sed luctus diam id lectus suscipit, sit amet rhoncus enim imperdiet.",
"Curabitur sodales mi in ante interdum commodo.",
"Etiam ultrices justo id est laoreet, sit amet rhoncus mauris tempus.",
"Cras bibendum metus a ex iaculis, sed suscipit lacus rhoncus.",
"Phasellus non tortor et quam aliquet consequat.",
"Quisque commodo odio gravida elit venenatis fringilla.",
"Nullam ultricies leo non eleifend facilisis.",
"In commodo ante eget ex eleifend, ut vulputate nisi venenatis.",
"Nullam vitae lectus vel dolor rhoncus eleifend.",
"Maecenas tincidunt libero eu augue suscipit eleifend.",
"Aenean non leo pellentesque, dapibus enim vitae, condimentum mi.",
"Aliquam vitae sem ac massa scelerisque vehicula ac nec erat.",
"Etiam sed sapien id ex elementum scelerisque.",
"Curabitur pharetra nunc sed sem hendrerit scelerisque.",
"Sed volutpat quam non ornare consectetur.",
"Sed eu sem at leo pulvinar lobortis vitae in dui.",
"Quisque lobortis enim pellentesque, dignissim lorem et, lacinia tortor.",
"Vestibulum lobortis ipsum sit amet neque lobortis, sit amet finibus mauris sagittis.",
"Maecenas porttitor turpis quis laoreet tristique.",
"Phasellus mollis nibh sit amet imperdiet facilisis.",
"Sed congue augue dapibus lorem elementum congue.",
"Praesent dictum massa ut risus elementum, at pulvinar felis faucibus.",
"Aenean eu mi sed ligula auctor laoreet.",
"Morbi porttitor nisl in neque vulputate, id vestibulum neque feugiat.",
"Morbi nec elit et quam dictum viverra a quis felis.",
"Vivamus tempus augue et risus bibendum aliquet.",
"Morbi eget libero at diam efficitur congue.",
"Nam facilisis massa eleifend turpis ullamcorper condimentum.",
"Aliquam nec mi at nibh consectetur rutrum nec at nibh.",
"Fusce at nisi quis lectus laoreet tincidunt.",
"Mauris egestas mauris ac diam ornare imperdiet.",
"Fusce in magna non nisi venenatis interdum.",
"Phasellus sit amet lacus dictum, fermentum sapien nec, commodo odio.",
"Sed faucibus mauris non nisl faucibus, pellentesque sollicitudin enim tincidunt.",
"Integer hendrerit massa in mauris auctor, vel varius libero fermentum.",
"Aenean blandit turpis vel ex accumsan porta.",
"Nulla cursus nulla a ipsum bibendum ornare.",
"Phasellus sollicitudin nisi at tortor dictum, sit amet consectetur sem elementum.",
"Morbi et mauris vehicula mauris mattis mollis eget et sapien.",
"Curabitur rutrum ex sed convallis fermentum.",
"Suspendisse aliquet libero vel augue sodales ultrices.",
"Morbi sagittis nulla sed aliquam blandit.",
"Donec eleifend purus ut libero lacinia, eu molestie nulla volutpat.",
"Praesent rutrum massa eget bibendum vestibulum.",
"Vestibulum ac arcu finibus, laoreet ex non, elementum nulla.",
"Etiam iaculis magna id nibh semper facilisis.",
"Nullam nec tellus non ligula laoreet accumsan.",
"Sed feugiat erat a faucibus porttitor.",
"Nunc vel eros sed erat aliquet lobortis at id orci.",
"Fusce tempor tortor quis nisl fermentum placerat.",
"Vivamus tempor est ac augue convallis volutpat.",
"Proin suscipit diam vel purus scelerisque commodo vel ac mi.",
"Sed laoreet purus nec sem posuere eleifend eget a odio.",
"Sed sed purus eu nisl porta vulputate vitae sit amet urna.",
"Sed vel metus scelerisque, porttitor orci sit amet, feugiat massa.",
"Curabitur consectetur diam vel ligula dignissim condimentum.",
"Integer a felis quis massa auctor pretium vel eget sapien.",
"Mauris eleifend urna et lacus ornare facilisis.",
"Mauris vulputate turpis fermentum tellus egestas, vitae dignissim nisi accumsan.",
"In accumsan risus eget erat faucibus, quis congue nunc pellentesque.",
"Proin nec sapien non orci vestibulum sodales et a enim.",
"Duis placerat nunc a ipsum ultricies varius.",
"Vivamus blandit mi quis dolor dignissim condimentum.",
"Pellentesque vitae ex posuere, interdum tellus in, aliquam ligula.",
"Vivamus lobortis ipsum et ipsum tempus, a euismod tortor ultricies.",
"Aliquam sollicitudin dolor fermentum metus elementum volutpat.",
"Sed et velit nec velit iaculis semper at pretium erat.",
"Donec luctus libero in est maximus fringilla.",
"Sed non tortor id ante facilisis gravida.",
"Mauris a turpis eu ligula elementum sodales.",
"Quisque faucibus velit non sem rhoncus, nec porttitor ipsum tincidunt.",
"Sed sed diam quis urna tristique facilisis.",
"Vestibulum id orci non nisi accumsan elementum eget ac turpis.",
"In id urna a enim dapibus congue.",
"Donec at nibh pellentesque, suscipit lacus ut, euismod felis.",
"Proin vitae quam euismod, mattis justo sit amet, laoreet ipsum.",
"Mauris sed nisi porta, semper turpis eget, ullamcorper nisi.",
"Aenean ornare orci at leo commodo eleifend.",
"Nam varius nibh id dictum pretium.",
"Integer condimentum nisl id ante vulputate commodo.",
"Quisque lacinia eros sit amet nisi congue lobortis.",
"Integer condimentum odio vitae leo molestie rutrum.",
"Cras sit amet nunc dictum, vehicula est in, cursus augue.",
"Aenean sed nibh ut augue convallis porttitor vel id sapien.",
"Donec id leo vestibulum arcu auctor vulputate.",
"Duis ac dui vitae nisi viverra bibendum id quis turpis.",
"Proin aliquam nunc eget justo ultricies tempus.",
"Suspendisse ut mi ut nisi elementum ornare.",
"Quisque vel sem quis augue interdum congue.",
"Vivamus fermentum tortor egestas, mattis nibh eget, ultricies turpis.",
"Ut facilisis dui nec lectus convallis, sit amet suscipit lectus ullamcorper.",
"Curabitur egestas dui sed purus ullamcorper porttitor.",
"Sed sit amet augue venenatis, vehicula dolor et, imperdiet purus.",
"Aenean posuere orci vitae dolor sollicitudin rutrum.",
"Quisque aliquam velit porta, sodales ligula mollis, hendrerit ex.",
"Aliquam vitae mi nec enim placerat pellentesque in at justo.",
"Nam vehicula magna at feugiat varius.",
"Donec in dui bibendum, tincidunt augue sit amet, pharetra arcu.",
"Nulla eu eros at dui consequat suscipit quis at nisl.",
"Ut sed dolor ut sapien dapibus laoreet eget nec sem.",
"Sed sed dui at lectus egestas porta.",
"Pellentesque fringilla ligula et felis ultricies porttitor.",
"Aliquam lobortis lacus ut maximus ullamcorper.",
"In congue sem sed nulla laoreet auctor.",
"Nunc mollis metus eu est lacinia, vel laoreet enim convallis.",
"Morbi sed mauris varius justo rutrum consequat fringilla tristique urna.",
"Donec commodo nibh vitae massa condimentum sagittis.",
"Nam porta ligula a suscipit mattis.",
"Nam imperdiet mauris at justo aliquam ultrices sed quis ante.",
"In consequat dui aliquet sem consequat, ut fringilla ante ultricies.",
"Cras ac dolor id dui ullamcorper vestibulum.",
"Nunc in nisl lacinia justo egestas interdum quis in metus.",
"Vivamus nec erat et velit fringilla maximus.",
"Nunc commodo purus id orci auctor, tempor malesuada lacus semper.",
"Mauris tempor sem ac quam feugiat, non bibendum tortor commodo.",
"In a nisl sit amet ex condimentum malesuada id ut lectus.",
"Donec sed dui eget eros volutpat hendrerit vitae non sapien.",
"Cras non justo feugiat urna venenatis molestie in et magna.",
"Curabitur fermentum felis ut aliquam porttitor.",
"Morbi eu sapien dictum, volutpat nulla ac, tincidunt sapien.",
"Sed vel urna pulvinar, ullamcorper risus at, maximus arcu.",
"Vestibulum sit amet sapien a tellus tincidunt consequat id sit amet tortor.",
"Integer vel ante sit amet erat sagittis vestibulum sit amet vel lacus.",
"Mauris vestibulum nunc id nisl dictum tincidunt.",
"Donec a dolor dictum, imperdiet neque sodales, blandit leo.",
"Cras eu lectus tincidunt, accumsan justo vestibulum, malesuada odio.",
"Aliquam scelerisque libero quis mi egestas ultricies.",
"Sed non turpis condimentum, eleifend orci in, faucibus augue.",
"Vestibulum volutpat nulla id magna accumsan, sed pellentesque odio commodo.",
"Curabitur non massa dictum, iaculis est non, venenatis ligula.",
"Integer dignissim arcu at arcu ornare tincidunt.",
"Vivamus eu orci at nisl consequat vehicula id eu magna.",
"Aenean rutrum diam eu turpis scelerisque euismod.",
"Nam maximus nibh in diam bibendum, at vehicula ex facilisis.",
"Pellentesque pellentesque orci ut arcu imperdiet, eget iaculis nunc tristique.",
"Integer in libero euismod, facilisis est eget, volutpat augue.",
"Integer sodales ipsum posuere odio hendrerit ultrices.",
"Donec aliquet nisl non sapien imperdiet, quis semper lacus commodo.",
"Nam consequat lorem vel dolor vulputate cursus.",
"Duis eget tortor egestas, maximus velit sed, aliquet risus.",
"Nunc quis lectus et quam dignissim luctus.",
"Sed feugiat urna eget tristique interdum.",
"Sed lacinia lorem id sapien pellentesque gravida.",
"Sed convallis tellus vitae nisl sagittis, ac rutrum justo tincidunt.",
"Donec sit amet enim id lorem sagittis aliquet.",
"Praesent ut diam lacinia, volutpat lectus id, egestas metus.",
"Nunc bibendum quam fringilla ipsum condimentum, malesuada commodo libero ultrices.",
"Praesent id quam porta, laoreet ligula eu, rhoncus risus.",
"Praesent quis arcu eu est varius congue.",
"Aenean faucibus mauris ut risus feugiat, eget accumsan eros lacinia.",
"Vestibulum quis magna sed risus consequat vestibulum a ac dui.",
"Aliquam cursus urna sit amet luctus hendrerit.",
"In viverra ex sed felis vestibulum vulputate.",
"Ut maximus odio a pellentesque dictum.",
"Praesent sagittis ante nec faucibus molestie.",
"Praesent ut mauris vitae sapien consequat pulvinar ac vitae nisl.",
"Duis vitae orci et tellus viverra mollis ullamcorper malesuada quam.",
"Curabitur sollicitudin dolor eget convallis porta.",
"Ut at metus posuere nulla ullamcorper fermentum.",
"In vehicula ligula in arcu rutrum, viverra egestas ligula pretium.",
"Suspendisse sollicitudin nisl eu augue sagittis, sit amet malesuada ex condimentum.",
"Suspendisse consectetur arcu ut neque ornare faucibus.",
"Fusce ut erat semper, consequat justo in, viverra nisi.",
"Ut posuere nisl eleifend dui aliquam, quis semper ex dignissim.",
"Donec quis magna eu libero sodales laoreet.",
"Maecenas sed purus aliquet, pharetra sapien id, viverra purus.",
"Pellentesque et erat pulvinar, lacinia magna a, aliquam felis.",
"Nam vitae nibh in leo lobortis semper.",
"Mauris hendrerit turpis bibendum velit aliquam, in viverra quam vulputate.",
"Vivamus at tortor vitae augue molestie egestas.",
"Vestibulum id sapien quis orci ultrices fringilla.",
"Aenean sollicitudin ante in convallis congue.",
"Aliquam facilisis est at est lobortis, a mattis mauris dignissim.",
"Donec lacinia mi fringilla porttitor lacinia.",
"Aliquam auctor ante quis tellus blandit, ac ullamcorper tortor egestas.",
"Fusce egestas ex a ex euismod, eu rhoncus libero maximus.",
"In et velit cursus, fringilla lorem in, scelerisque metus.",
"Aliquam gravida massa quis ligula tincidunt, a vestibulum nisi commodo.",
"Duis eu nulla vehicula, sollicitudin ex ac, scelerisque nisi.",
"Donec sit amet mi eget dolor placerat cursus pulvinar eget odio.",
"Praesent convallis turpis ac rhoncus lacinia.",
"Etiam viverra mi sed ligula cursus pulvinar.",
"Sed et ex iaculis, sagittis neque varius, maximus sapien.",
"Phasellus suscipit ipsum et magna bibendum mattis.",
"Nulla nec est ac nisi viverra ullamcorper.",
"Nulla ultrices nulla ornare orci condimentum aliquet.",
"Mauris porttitor mauris eget est egestas viverra.",
"Quisque at augue id ante posuere facilisis et non odio.",
"Fusce consequat felis non neque varius, in posuere sapien mollis.",
"Nunc finibus elit nec lorem sodales, at vulputate arcu iaculis.",
"Duis vitae ex interdum, vehicula sapien vitae, ullamcorper est.",
"Morbi eget nibh at quam eleifend cursus aliquet ut magna.",
"Suspendisse eu leo sed dui rhoncus semper.",
"Aenean tincidunt felis at venenatis gravida.",
"Morbi commodo sapien et efficitur fringilla.",
"Nulla at sapien faucibus, finibus sem ac, posuere lacus.",
"Mauris vel magna maximus leo pretium molestie.",
"Etiam pulvinar risus eu fermentum volutpat.",
"Duis eu nisl a sapien finibus pellentesque.",
"Integer in sem vestibulum metus suscipit bibendum vitae a odio.",
"Sed non massa maximus, imperdiet enim in, congue metus.",
"Duis tincidunt nunc id eros euismod, non pharetra tortor tempus.",
"Sed imperdiet est tempus mi luctus posuere.",
"Ut at ex fermentum, sodales lacus efficitur, imperdiet lorem.",
"Integer tristique elit eget lectus efficitur malesuada.",
"Morbi pharetra turpis nec mauris ultrices, ac fermentum nisl tempor.",
"Nunc pretium nisi ac auctor varius.",
"Morbi eu mauris eget neque faucibus euismod.",
"Cras fringilla est sed iaculis mollis.",
"Suspendisse rhoncus libero vel ipsum accumsan venenatis.",
"Praesent ac lacus vel nulla pellentesque pulvinar in in diam.",
"Aliquam tristique lectus sit amet lacus scelerisque, a rhoncus lacus blandit.",
"In ac est elementum, volutpat ante quis, gravida quam.",
"Fusce vulputate dolor vel posuere feugiat.",
"Pellentesque faucibus felis a est finibus molestie.",
"Praesent nec enim molestie, hendrerit neque quis, vestibulum sapien.",
"Maecenas non sapien ut diam congue consequat.",
"Fusce in eros quis felis placerat egestas.",
"Fusce bibendum arcu et nisi lacinia, vel dignissim ante molestie.",
"Nunc consectetur mi in condimentum vestibulum.",
"Suspendisse a elit id neque commodo laoreet.",
"In rhoncus metus sed elit aliquam congue.",
"Mauris sagittis mi non diam iaculis hendrerit.",
"Mauris tempus ex eu sem pretium, nec lobortis neque vulputate.",
"Proin consectetur justo a dictum sollicitudin.",
"Sed bibendum diam sed metus porta pharetra.",
"Suspendisse pulvinar nunc id quam lacinia semper.",
"Aenean eleifend magna id enim placerat, quis pretium eros mattis.",
"Aenean blandit massa nec volutpat feugiat.",
"Quisque viverra ligula vitae justo finibus hendrerit.",
"Nullam in nisi eget massa feugiat maximus.",
"Vivamus blandit magna id dui porta interdum.",
"Ut id tortor vel urna tempor ultricies.",
"Morbi at diam in ligula auctor luctus id a dui.",
"Fusce at eros nec nunc sollicitudin molestie.",
"Pellentesque gravida tortor non ornare convallis.",
"Mauris sed nisi eu arcu egestas semper sit amet eget eros.",
"Vestibulum at ex porta, hendrerit nisi et, blandit dui.",
"Donec ornare justo eu ligula lobortis, sed dignissim augue congue.",
"Maecenas ornare est at ipsum consectetur, a euismod tortor ornare.",
"Fusce ac nisi sodales, ultricies magna ut, convallis risus.",
"In vel erat vitae dolor molestie condimentum in vitae felis.",
"Mauris vel risus ac velit scelerisque rhoncus id sit amet ex.",
"Sed nec ex vitae mauris tempor aliquet quis vel magna.",
"Vivamus eget ipsum suscipit, gravida ex in, suscipit nisi.",
"Fusce viverra mi euismod lacus condimentum, eu congue turpis dignissim.",
"Duis vel odio in turpis imperdiet cursus.",
"Cras vitae dolor rutrum, mollis diam eget, tempor leo.",
"Praesent vitae lorem volutpat, vehicula lectus porttitor, tincidunt arcu.",
"Pellentesque ut tellus quis libero fermentum pulvinar.",
"Nullam fringilla metus at diam aliquam feugiat.",
"Nulla fringilla tortor mattis augue hendrerit pulvinar.",
"Nullam vestibulum magna et urna volutpat auctor.",
"Aenean eleifend tellus a congue lacinia.",
"Nunc at neque quis tellus blandit viverra porta id erat.",
"Vivamus quis nibh iaculis, laoreet ipsum eget, vulputate eros.",
"Donec vel turpis in metus maximus cursus.",
"Duis dignissim justo vitae eros maximus laoreet.",
"Cras consequat nisi vel ipsum tincidunt malesuada.",
"Sed euismod enim quis elit malesuada mollis.",
"Donec sed magna dignissim, dictum metus sit amet, consequat magna.",
"Morbi fringilla enim quis turpis malesuada mollis."
            };

            IQueryable<string> queryable = stList.Where(p => p.Contains(" ")).AsQueryable<string>();
            queryable = queryable.Pagination(20, 3);

            Assert.AreEqual(20, queryable.Count());

            IEnumerable<string> enumerable = stList.Where(p => p.Contains(" "));
            enumerable = enumerable.Pagination(20, 3);
            Assert.AreEqual(20, enumerable.Count());
        }
    }
}