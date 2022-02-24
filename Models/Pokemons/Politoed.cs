using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Politoed Specie to store common natural stats of every {'abilities': ['water-absorb', 'damp', 'drizzle'], 'base_experience': 225, 'height': 11, 'id': 186, 'moves': ['double-slap', 'mega-punch', 'ice-punch', 'mega-kick', 'headbutt', 'body-slam', 'double-edge', 'water-gun', 'surf', 'ice-beam', 'blizzard', 'bubble-beam', 'hyper-beam', 'counter', 'seismic-toss', 'strength', 'earthquake', 'dig', 'toxic', 'psychic', 'hypnosis', 'mimic', 'double-team', 'defense-curl', 'metronome', 'waterfall', 'rest', 'substitute', 'thief', 'snore', 'curse', 'protect', 'mud-slap', 'perish-song', 'icy-wind', 'detect', 'endure', 'swagger', 'attract', 'sleep-talk', 'return', 'frustration', 'dynamic-punch', 'hidden-power', 'rain-dance', 'rock-smash', 'whirlpool', 'hail', 'facade', 'focus-punch', 'helping-hand', 'brick-break', 'endeavor', 'secret-power', 'dive', 'hyper-voice', 'bounce', 'water-pulse', 'natural-gift', 'payback', 'fling', 'focus-blast', 'giga-impact', 'captivate', 'round', 'echoed-voice', 'scald', 'bulldoze', 'confide', 'power-up-punch'], 'name': 'politoed', 'stats': {'hp': 90, 'attack': 75, 'defense': 75, 'special-attack': 90, 'special-defense': 100, 'speed': 70}, 'types': ['water'], 'weight': 339, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 20, 'gender_rate': 4, 'capture_rate': 45, 'color': 'green', 'shape': 'humanoid', 'habitat': 'waters-edge', 'generation': 'generation-ii', 'growth_rate': 'medium-slow', 'egg_groups': ['water1'], 'names': {'ja-Hrkt': 'ニョロトノ', 'roomaji': 'Nyorotono', 'ko': '왕구리', 'zh-Hant': '蚊香蛙皇', 'fr': 'Tarpaud', 'de': 'Quaxo', 'es': 'Politoed', 'it': 'Politoed', 'en': 'Politoed', 'ja': 'ニョロトノ', 'zh-Hans': '蚊香蛙皇'}, 'genera': {'ja-Hrkt': 'かえるポケモン', 'ko': '개구리포켓몬', 'zh-Hant': '蛙寶可夢', 'fr': 'Pokémon Grenouille', 'de': 'Frosch', 'es': 'Pokémon Rana', 'it': 'Pokémon Rana', 'en': 'Frog Pokémon', 'ja': 'かえるポケモン', 'zh-Hans': '蛙宝可梦'}}
	public class SpeciePolitoed : PokemonSpecie
	{
#nullable enable
		private static SpeciePolitoed? _instance = null;
#nullable restore
        public static SpeciePolitoed Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciePolitoed();
                }
                return _instance;
            }
        }

		public SpeciePolitoed() : base(
			"Politoed",
			90, // HPs
			75, 75, // Attack & Defense
			90, 100, // Special Attack & Defense
			70			
		) {}
	}


	//Politoed Pokemon Class
	public class Politoed : Pokemon
	{

		public Politoed(string nickname, int level)
		: base(
				186,
				SpeciePolitoed.Instance, // Pokemon Specie
				nickname, level,
				Water.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Politoed() : base(
			186,
			SpeciePolitoed.Instance, // Pokemon Specie
			Water.Instance			
		) {}
	}
}