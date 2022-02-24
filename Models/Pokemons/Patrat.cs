using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Patrat Specie to store common natural stats of every {'abilities': ['run-away', 'keen-eye', 'analytic'], 'base_experience': 51, 'height': 5, 'id': 504, 'moves': ['swords-dance', 'cut', 'slam', 'sand-attack', 'tackle', 'leer', 'bite', 'low-kick', 'thunderbolt', 'dig', 'toxic', 'hypnosis', 'screech', 'double-team', 'focus-energy', 'bide', 'rest', 'hyper-fang', 'super-fang', 'substitute', 'snore', 'flail', 'protect', 'foresight', 'detect', 'swagger', 'mean-look', 'attract', 'sleep-talk', 'return', 'frustration', 'baton-pass', 'pursuit', 'iron-tail', 'hidden-power', 'rain-dance', 'sunny-day', 'crunch', 'shadow-ball', 'facade', 'helping-hand', 'revenge', 'endeavor', 'secret-power', 'bullet-seed', 'covet', 'shock-wave', 'assurance', 'fling', 'last-resort', 'aqua-tail', 'seed-bomb', 'nasty-plot', 'zen-headbutt', 'gunk-shot', 'grass-knot', 'after-you', 'round', 'retaliate', 'work-up', 'confide', 'tearful-look'], 'name': 'patrat', 'stats': {'hp': 45, 'attack': 55, 'defense': 39, 'special-attack': 35, 'special-defense': 39, 'speed': 42}, 'types': ['normal'], 'weight': 116, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 15, 'gender_rate': 4, 'capture_rate': 255, 'color': 'brown', 'shape': 'quadruped', 'habitat': None, 'generation': 'generation-v', 'growth_rate': 'medium', 'egg_groups': ['ground'], 'names': {'ja-Hrkt': 'ミネズミ', 'ko': '보르쥐', 'zh-Hant': '探探鼠', 'fr': 'Ratentif', 'de': 'Nagelotz', 'es': 'Patrat', 'it': 'Patrat', 'en': 'Patrat', 'ja': 'ミネズミ', 'zh-Hans': '探探鼠'}, 'genera': {'ja-Hrkt': 'みはりポケモン', 'ko': '망보기포켓몬', 'zh-Hant': '放哨寶可夢', 'fr': 'Pokémon Espion', 'de': 'Späher', 'es': 'Pokémon Explorador', 'it': 'Pokémon Esplorante', 'en': 'Scout Pokémon', 'ja': 'みはりポケモン', 'zh-Hans': '放哨宝可梦'}}
	public class SpeciePatrat : PokemonSpecie
	{
#nullable enable
		private static SpeciePatrat? _instance = null;
#nullable restore
        public static SpeciePatrat Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciePatrat();
                }
                return _instance;
            }
        }

		public SpeciePatrat() : base(
			"Patrat",
			45, // HPs
			55, 39, // Attack & Defense
			35, 39, // Special Attack & Defense
			42			
		) {}
	}


	//Patrat Pokemon Class
	public class Patrat : Pokemon
	{

		public Patrat(string nickname, int level)
		: base(
				504,
				SpeciePatrat.Instance, // Pokemon Specie
				nickname, level,
				Normal.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Patrat(int level)
		: base(
				504,
				SpeciePatrat.Instance, // Pokemon Specie
				"Patrat", level,
				Normal.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Patrat() : base(
			504,
			SpeciePatrat.Instance, // Pokemon Specie
			Normal.Instance			
		) {}
	}
}