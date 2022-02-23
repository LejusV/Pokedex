using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Dartrix Specie to store common natural stats of every {'abilities': ['overgrow', 'long-reach'], 'base_experience': 147, 'height': 7, 'id': 723, 'moves': ['swords-dance', 'fury-attack', 'tackle', 'growl', 'peck', 'razor-leaf', 'solar-beam', 'toxic', 'double-team', 'light-screen', 'rest', 'substitute', 'protect', 'foresight', 'false-swipe', 'swagger', 'steel-wing', 'attract', 'sleep-talk', 'return', 'frustration', 'safeguard', 'synthesis', 'hidden-power', 'sunny-day', 'facade', 'nature-power', 'feather-dance', 'astonish', 'leaf-blade', 'roost', 'pluck', 'sucker-punch', 'energy-ball', 'brave-bird', 'nasty-plot', 'shadow-claw', 'grass-knot', 'ominous-wind', 'round', 'echoed-voice', 'grass-pledge', 'work-up', 'confide', 'leafage'], 'name': 'dartrix', 'stats': {'hp': 78, 'attack': 75, 'defense': 75, 'special-attack': 70, 'special-defense': 70, 'speed': 52}, 'types': ['grass', 'flying'], 'weight': 160, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 15, 'gender_rate': 1, 'capture_rate': 45, 'color': 'brown', 'shape': 'wings', 'habitat': None, 'generation': 'generation-vii', 'growth_rate': 'medium-slow', 'egg_groups': ['flying'], 'names': {'ja-Hrkt': 'フクスロー', 'ko': '빼미스로우', 'zh-Hant': '投羽梟', 'fr': 'Efflèche', 'de': 'Arboretoss', 'es': 'Dartrix', 'it': 'Dartrix', 'en': 'Dartrix', 'ja': 'フクスロー', 'zh-Hans': '投羽枭'}, 'genera': {'ja-Hrkt': 'はばねポケモン', 'ko': '칼날깃포켓몬', 'zh-Hant': '刃羽寶可夢', 'fr': 'Pokémon Plum’acérée', 'de': 'Flügelklinge', 'es': 'Pokémon Pluma Filo', 'it': 'Pokémon Piumaffilata', 'en': 'Blade Quill Pokémon', 'ja': 'はばねポケモン', 'zh-Hans': '刃羽宝可梦'}}
	public class SpecieDartrix : PokemonSpecie
	{
#nullable enable
		private static SpecieDartrix? _instance = null;
#nullable restore
        public static SpecieDartrix Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieDartrix();
                }
                return _instance;
            }
        }

		public SpecieDartrix() : base(
			"Dartrix",
			78, // HPs
			75, 75, // Attack & Defense
			70, 70, // Special Attack & Defense
			52			
		) {}
	}


	//Dartrix Pokemon Class
	public class Dartrix : Pokemon
	{

		public Dartrix(string nickname, int level) : base(
			723,
			SpecieDartrix.Instance, // Pokemon Specie
			nickname, level,
			Grass.Instance, Flying.Instance			
		) {}

		public Dartrix() : base(
			723,
			SpecieDartrix.Instance, // Pokemon Specie
			Grass.Instance, Flying.Instance			
		) {}
	}
}