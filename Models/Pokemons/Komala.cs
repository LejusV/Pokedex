using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Komala Specie to store common natural stats of every {'abilities': ['comatose'], 'base_experience': 168, 'height': 4, 'id': 775, 'moves': ['swords-dance', 'slam', 'thrash', 'sing', 'earthquake', 'toxic', 'double-team', 'defense-curl', 'rock-slide', 'substitute', 'flail', 'protect', 'charm', 'rollout', 'swagger', 'attract', 'sleep-talk', 'return', 'frustration', 'rapid-spin', 'hidden-power', 'sunny-day', 'psych-up', 'stockpile', 'spit-up', 'swallow', 'facade', 'wish', 'brick-break', 'yawn', 'bulk-up', 'calm-mind', 'u-turn', 'payback', 'sucker-punch', 'shadow-claw', 'wood-hammer', 'low-sweep', 'round', 'quash', 'acrobatics', 'bulldoze', 'work-up', 'play-rough', 'confide'], 'name': 'komala', 'stats': {'hp': 65, 'attack': 115, 'defense': 65, 'special-attack': 75, 'special-defense': 95, 'speed': 65}, 'types': ['normal'], 'weight': 199, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 20, 'gender_rate': 4, 'capture_rate': 45, 'color': 'blue', 'shape': 'humanoid', 'habitat': None, 'generation': 'generation-vii', 'growth_rate': 'slow', 'egg_groups': ['ground'], 'names': {'ja-Hrkt': 'ネッコアラ', 'ko': '자말라', 'zh-Hant': '樹枕尾熊', 'fr': 'Dodoala', 'de': 'Koalelu', 'es': 'Komala', 'it': 'Komala', 'en': 'Komala', 'ja': 'ネッコアラ', 'zh-Hans': '树枕尾熊'}, 'genera': {'ja-Hrkt': 'ゆめうつつポケモン', 'ko': '꿈결포켓몬', 'zh-Hant': '半夢半醒寶可夢', 'fr': 'Pokémon Rêveur', 'de': 'Halbschlaf', 'es': 'Pokémon Duermevela', 'it': 'Pokémon Dormiveglia', 'en': 'Drowsing Pokémon', 'ja': 'ゆめうつつポケモン', 'zh-Hans': '半梦半醒宝可梦'}}
	public class SpecieKomala : PokemonSpecie
	{
#nullable enable
		private static SpecieKomala? _instance = null;
#nullable restore
        public static SpecieKomala Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieKomala();
                }
                return _instance;
            }
        }

		public SpecieKomala() : base(
			"Komala",
			65, // HPs
			115, 65, // Attack & Defense
			75, 95, // Special Attack & Defense
			65			
		) {}
	}


	//Komala Pokemon Class
	public class Komala : Pokemon
	{

		public Komala(string nickname, int level)
		: base(
				775,
				SpecieKomala.Instance, // Pokemon Specie
				nickname, level,
				Normal.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Komala() : base(
			775,
			SpecieKomala.Instance, // Pokemon Specie
			Normal.Instance			
		) {}
	}
}