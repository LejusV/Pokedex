using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Decidueye Specie to store common natural stats of every {'abilities': ['overgrow', 'long-reach'], 'base_experience': 239, 'height': 16, 'id': 724, 'moves': ['swords-dance', 'fury-attack', 'tackle', 'growl', 'peck', 'razor-leaf', 'solar-beam', 'toxic', 'double-team', 'light-screen', 'rest', 'substitute', 'protect', 'foresight', 'false-swipe', 'swagger', 'steel-wing', 'attract', 'sleep-talk', 'return', 'frustration', 'safeguard', 'synthesis', 'hidden-power', 'sunny-day', 'shadow-ball', 'facade', 'nature-power', 'feather-dance', 'astonish', 'frenzy-plant', 'leaf-blade', 'roost', 'pluck', 'u-turn', 'sucker-punch', 'energy-ball', 'brave-bird', 'giga-impact', 'nasty-plot', 'shadow-claw', 'shadow-sneak', 'leaf-storm', 'grass-knot', 'ominous-wind', 'smack-down', 'low-sweep', 'round', 'echoed-voice', 'acrobatics', 'grass-pledge', 'work-up', 'phantom-force', 'confide', 'spirit-shackle', 'leafage'], 'name': 'decidueye', 'stats': {'hp': 78, 'attack': 107, 'defense': 75, 'special-attack': 100, 'special-defense': 100, 'speed': 70}, 'types': ['grass', 'ghost'], 'weight': 366, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 15, 'gender_rate': 1, 'capture_rate': 45, 'color': 'brown', 'shape': 'wings', 'habitat': None, 'generation': 'generation-vii', 'growth_rate': 'medium-slow', 'egg_groups': ['flying'], 'names': {'ja-Hrkt': 'ジュナイパー', 'ko': '모크나이퍼', 'zh-Hant': '狙射樹梟', 'fr': 'Archéduc', 'de': 'Silvarro', 'es': 'Decidueye', 'it': 'Decidueye', 'en': 'Decidueye', 'ja': 'ジュナイパー', 'zh-Hans': '狙射树枭'}, 'genera': {'ja-Hrkt': 'やばねポケモン', 'ko': '화살깃포켓몬', 'zh-Hant': '箭羽寶可夢', 'fr': 'Pokémon Plumeflèche', 'de': 'Pfeilflügel', 'es': 'Pokémon Pluma Flecha', 'it': 'Pokémon Alifreccia', 'en': 'Arrow Quill Pokémon', 'ja': 'やばねポケモン', 'zh-Hans': '箭羽宝可梦'}}
	public class SpecieDecidueye : PokemonSpecie
	{
#nullable enable
		private static SpecieDecidueye? _instance = null;
#nullable restore
        public static SpecieDecidueye Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieDecidueye();
                }
                return _instance;
            }
        }

		public SpecieDecidueye() : base(
			"Decidueye",
			78, // HPs
			107, 75, // Attack & Defense
			100, 100, // Special Attack & Defense
			70			
		) {}
	}


	//Decidueye Pokemon Class
	public class Decidueye : Pokemon
	{

		public Decidueye(string nickname, int level)
		: base(
				724,
				SpecieDecidueye.Instance, // Pokemon Specie
				nickname, level,
				Grass.Instance, Ghost.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Decidueye() : base(
			724,
			SpecieDecidueye.Instance, // Pokemon Specie
			Grass.Instance, Ghost.Instance			
		) {}
	}
}