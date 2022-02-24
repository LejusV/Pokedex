using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Gogoat Specie to store common natural stats of every {'abilities': ['sap-sipper', 'grass-pelt'], 'base_experience': 186, 'height': 17, 'id': 673, 'moves': ['vine-whip', 'tackle', 'take-down', 'double-edge', 'tail-whip', 'roar', 'surf', 'hyper-beam', 'strength', 'leech-seed', 'growth', 'razor-leaf', 'solar-beam', 'earthquake', 'dig', 'toxic', 'double-team', 'rest', 'rock-slide', 'substitute', 'snore', 'protect', 'giga-drain', 'swagger', 'milk-drink', 'attract', 'sleep-talk', 'return', 'frustration', 'iron-tail', 'synthesis', 'hidden-power', 'rain-dance', 'sunny-day', 'rock-smash', 'facade', 'nature-power', 'superpower', 'brick-break', 'secret-power', 'aerial-ace', 'bulk-up', 'bounce', 'leaf-blade', 'payback', 'worry-seed', 'seed-bomb', 'energy-ball', 'giga-impact', 'zen-headbutt', 'grass-knot', 'round', 'retaliate', 'bulldoze', 'work-up', 'wild-charge', 'horn-leech', 'confide'], 'name': 'gogoat', 'stats': {'hp': 123, 'attack': 100, 'defense': 62, 'special-attack': 97, 'special-defense': 81, 'speed': 68}, 'types': ['grass'], 'weight': 910, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 20, 'gender_rate': 4, 'capture_rate': 45, 'color': 'brown', 'shape': 'quadruped', 'habitat': None, 'generation': 'generation-vi', 'growth_rate': 'medium', 'egg_groups': ['ground'], 'names': {'ja-Hrkt': 'ゴーゴート', 'ko': '고고트', 'zh-Hant': '坐騎山羊', 'fr': 'Chevroum', 'de': 'Chevrumm', 'es': 'Gogoat', 'it': 'Gogoat', 'en': 'Gogoat', 'ja': 'ゴーゴート', 'zh-Hans': '坐骑山羊'}, 'genera': {'ja-Hrkt': 'ライドポケモン', 'ko': '라이드포켓몬', 'zh-Hant': '坐騎寶可夢', 'fr': 'Pokémon Monture', 'de': 'Ritt', 'es': 'Pokémon Montura', 'it': 'Pokémon Cavalcatura', 'en': 'Mount Pokémon', 'ja': 'ライドポケモン', 'zh-Hans': '坐骑宝可梦'}}
	public class SpecieGogoat : PokemonSpecie
	{
#nullable enable
		private static SpecieGogoat? _instance = null;
#nullable restore
        public static SpecieGogoat Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieGogoat();
                }
                return _instance;
            }
        }

		public SpecieGogoat() : base(
			"Gogoat",
			123, // HPs
			100, 62, // Attack & Defense
			97, 81, // Special Attack & Defense
			68			
		) {}
	}


	//Gogoat Pokemon Class
	public class Gogoat : Pokemon
	{

		public Gogoat(string nickname, int level)
		: base(
				673,
				SpecieGogoat.Instance, // Pokemon Specie
				nickname, level,
				Grass.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Gogoat(int level)
		: base(
				673,
				SpecieGogoat.Instance, // Pokemon Specie
				"Gogoat", level,
				Grass.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Gogoat() : base(
			673,
			SpecieGogoat.Instance, // Pokemon Specie
			Grass.Instance			
		) {}
	}
}