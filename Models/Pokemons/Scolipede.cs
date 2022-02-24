using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Scolipede Specie to store common natural stats of every {'abilities': ['poison-point', 'swarm', 'speed-boost'], 'base_experience': 218, 'height': 25, 'id': 545, 'moves': ['swords-dance', 'cut', 'double-edge', 'poison-sting', 'hyper-beam', 'strength', 'solar-beam', 'earthquake', 'dig', 'toxic', 'agility', 'screech', 'double-team', 'defense-curl', 'rest', 'rock-slide', 'substitute', 'snore', 'protect', 'sludge-bomb', 'rollout', 'swagger', 'attract', 'sleep-talk', 'return', 'frustration', 'megahorn', 'baton-pass', 'pursuit', 'iron-tail', 'hidden-power', 'sunny-day', 'rock-smash', 'facade', 'superpower', 'endeavor', 'snatch', 'secret-power', 'rock-tomb', 'signal-beam', 'iron-defense', 'poison-tail', 'gyro-ball', 'payback', 'poison-jab', 'aqua-tail', 'x-scissor', 'giga-impact', 'rock-climb', 'bug-bite', 'venoshock', 'round', 'struggle-bug', 'bulldoze', 'steamroller', 'confide', 'venom-drench', 'infestation', 'smart-strike'], 'name': 'scolipede', 'stats': {'hp': 60, 'attack': 100, 'defense': 89, 'special-attack': 55, 'special-defense': 69, 'speed': 112}, 'types': ['bug', 'poison'], 'weight': 2005, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 20, 'gender_rate': 4, 'capture_rate': 45, 'color': 'red', 'shape': 'armor', 'habitat': None, 'generation': 'generation-v', 'growth_rate': 'medium-slow', 'egg_groups': ['bug'], 'names': {'ja-Hrkt': 'ペンドラー', 'ko': '펜드라', 'zh-Hant': '蜈蚣王', 'fr': 'Brutapode', 'de': 'Cerapendra', 'es': 'Scolipede', 'it': 'Scolipede', 'en': 'Scolipede', 'ja': 'ペンドラー', 'zh-Hans': '蜈蚣王'}, 'genera': {'ja-Hrkt': 'メガムカデポケモン', 'ko': '메가지네포켓몬', 'zh-Hant': '巨蜈蚣寶可夢', 'fr': 'Pokémon Mégaplopode', 'de': 'Riesenfüßer', 'es': 'Pokémon Megaciempiés', 'it': 'Pokémon Megapede', 'en': 'Megapede Pokémon', 'ja': 'メガムカデポケモン', 'zh-Hans': '巨蜈蚣宝可梦'}}
	public class SpecieScolipede : PokemonSpecie
	{
#nullable enable
		private static SpecieScolipede? _instance = null;
#nullable restore
        public static SpecieScolipede Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieScolipede();
                }
                return _instance;
            }
        }

		public SpecieScolipede() : base(
			"Scolipede",
			60, // HPs
			100, 89, // Attack & Defense
			55, 69, // Special Attack & Defense
			112			
		) {}
	}


	//Scolipede Pokemon Class
	public class Scolipede : Pokemon
	{

		public Scolipede(string nickname, int level)
		: base(
				545,
				SpecieScolipede.Instance, // Pokemon Specie
				nickname, level,
				Bug.Instance, Poison.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Scolipede() : base(
			545,
			SpecieScolipede.Instance, // Pokemon Specie
			Bug.Instance, Poison.Instance			
		) {}
	}
}