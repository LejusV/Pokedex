using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Karrablast Specie to store common natural stats of every {'abilities': ['swarm', 'shed-skin', 'no-guard'], 'base_experience': 63, 'height': 5, 'id': 588, 'moves': ['swords-dance', 'cut', 'headbutt', 'horn-attack', 'fury-attack', 'take-down', 'double-edge', 'leer', 'peck', 'counter', 'toxic', 'screech', 'double-team', 'rest', 'slash', 'substitute', 'snore', 'flail', 'protect', 'scary-face', 'feint-attack', 'giga-drain', 'endure', 'false-swipe', 'swagger', 'fury-cutter', 'attract', 'sleep-talk', 'return', 'frustration', 'megahorn', 'pursuit', 'hidden-power', 'rain-dance', 'facade', 'knock-off', 'secret-power', 'signal-beam', 'aerial-ace', 'iron-defense', 'poison-jab', 'x-scissor', 'bug-buzz', 'energy-ball', 'bug-bite', 'round', 'struggle-bug', 'drill-run', 'confide', 'infestation'], 'name': 'karrablast', 'stats': {'hp': 50, 'attack': 75, 'defense': 45, 'special-attack': 40, 'special-defense': 45, 'speed': 60}, 'types': ['bug'], 'weight': 59, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 15, 'gender_rate': 4, 'capture_rate': 200, 'color': 'blue', 'shape': 'humanoid', 'habitat': None, 'generation': 'generation-v', 'growth_rate': 'medium', 'egg_groups': ['bug'], 'names': {'ja-Hrkt': 'カブルモ', 'ko': '딱정곤', 'zh-Hant': '蓋蓋蟲', 'fr': 'Carabing', 'de': 'Laukaps', 'es': 'Karrablast', 'it': 'Karrablast', 'en': 'Karrablast', 'ja': 'カブルモ', 'zh-Hans': '盖盖虫'}, 'genera': {'ja-Hrkt': 'かぶりつきポケモン', 'ko': '덥석물기포켓몬', 'zh-Hant': '啃咬寶可夢', 'fr': 'Pokémon Carabe', 'de': 'Schnappbiss', 'es': 'Pokémon Bocado', 'it': 'Pokémon Addentatore', 'en': 'Clamping Pokémon', 'ja': 'かぶりつきポケモン', 'zh-Hans': '啃咬宝可梦'}}
	public class SpecieKarrablast : PokemonSpecie
	{
#nullable enable
		private static SpecieKarrablast? _instance = null;
#nullable restore
        public static SpecieKarrablast Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieKarrablast();
                }
                return _instance;
            }
        }

		public SpecieKarrablast() : base(
			"Karrablast",
			50, // HPs
			75, 45, // Attack & Defense
			40, 45, // Special Attack & Defense
			60			
		) {}
	}


	//Karrablast Pokemon Class
	public class Karrablast : Pokemon
	{

		public Karrablast(string nickname, int level)
		: base(
				588,
				SpecieKarrablast.Instance, // Pokemon Specie
				nickname, level,
				Bug.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Karrablast() : base(
			588,
			SpecieKarrablast.Instance, // Pokemon Specie
			Bug.Instance			
		) {}
	}
}