using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Vanillish Specie to store common natural stats of every {'abilities': ['ice-body', 'snow-cloak', 'weak-armor'], 'base_experience': 138, 'height': 11, 'id': 583, 'moves': ['mist', 'ice-beam', 'blizzard', 'toxic', 'double-team', 'harden', 'light-screen', 'acid-armor', 'explosion', 'rest', 'substitute', 'snore', 'protect', 'icy-wind', 'swagger', 'attract', 'sleep-talk', 'return', 'frustration', 'hidden-power', 'rain-dance', 'mirror-coat', 'uproar', 'hail', 'facade', 'taunt', 'magic-coat', 'secret-power', 'astonish', 'signal-beam', 'sheer-cold', 'icicle-spear', 'iron-defense', 'water-pulse', 'magnet-rise', 'avalanche', 'mirror-shot', 'flash-cannon', 'round', 'frost-breath', 'confide'], 'name': 'vanillish', 'stats': {'hp': 51, 'attack': 65, 'defense': 65, 'special-attack': 80, 'special-defense': 75, 'speed': 59}, 'types': ['ice'], 'weight': 410, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 20, 'gender_rate': 4, 'capture_rate': 120, 'color': 'white', 'shape': 'blob', 'habitat': None, 'generation': 'generation-v', 'growth_rate': 'slow', 'egg_groups': ['mineral'], 'names': {'ja-Hrkt': 'バニリッチ', 'ko': '바닐리치', 'zh-Hant': '多多冰', 'fr': 'Sorboul', 'de': 'Gelatroppo', 'es': 'Vanillish', 'it': 'Vanillish', 'en': 'Vanillish', 'ja': 'バニリッチ', 'zh-Hans': '多多冰'}, 'genera': {'ja-Hrkt': 'ひょうせつポケモン', 'ko': '빙설포켓몬', 'zh-Hant': '冰雪寶可夢', 'fr': 'Pokémon Grêle', 'de': 'Firn', 'es': 'Pokémon Nieve Helada', 'it': 'Pokémon Geloneve', 'en': 'Icy Snow Pokémon', 'ja': 'ひょうせつポケモン', 'zh-Hans': '冰雪宝可梦'}}
	public class SpecieVanillish : PokemonSpecie
	{
#nullable enable
		private static SpecieVanillish? _instance = null;
#nullable restore
        public static SpecieVanillish Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieVanillish();
                }
                return _instance;
            }
        }

		public SpecieVanillish() : base(
			"Vanillish",
			51, // HPs
			65, 65, // Attack & Defense
			80, 75, // Special Attack & Defense
			59			
		) {}
	}


	//Vanillish Pokemon Class
	public class Vanillish : Pokemon
	{

		public Vanillish(string nickname, int level) : base(
			583,
			SpecieVanillish.Instance, // Pokemon Specie
			nickname, level,
			Ice.Instance			
		) {}

		public Vanillish() : base(
			583,
			SpecieVanillish.Instance, // Pokemon Specie
			Ice.Instance			
		) {}
	}
}