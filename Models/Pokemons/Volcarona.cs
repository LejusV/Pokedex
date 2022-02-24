using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Volcarona Specie to store common natural stats of every {'abilities': ['flame-body', 'swarm'], 'base_experience': 248, 'height': 16, 'id': 637, 'moves': ['gust', 'whirlwind', 'fly', 'thrash', 'ember', 'flamethrower', 'hyper-beam', 'absorb', 'solar-beam', 'string-shot', 'fire-spin', 'toxic', 'psychic', 'double-team', 'light-screen', 'fire-blast', 'amnesia', 'leech-life', 'rest', 'substitute', 'flame-wheel', 'snore', 'protect', 'giga-drain', 'swagger', 'sleep-talk', 'return', 'frustration', 'safeguard', 'hidden-power', 'sunny-day', 'heat-wave', 'will-o-wisp', 'facade', 'secret-power', 'overheat', 'silver-wind', 'signal-beam', 'aerial-ace', 'calm-mind', 'roost', 'tailwind', 'u-turn', 'magnet-rise', 'flare-blitz', 'poison-jab', 'bug-buzz', 'giga-impact', 'zen-headbutt', 'bug-bite', 'rage-powder', 'quiver-dance', 'flame-charge', 'round', 'incinerate', 'acrobatics', 'struggle-bug', 'wild-charge', 'hurricane', 'fiery-dance', 'confide'], 'name': 'volcarona', 'stats': {'hp': 85, 'attack': 60, 'defense': 65, 'special-attack': 135, 'special-defense': 105, 'speed': 100}, 'types': ['bug', 'fire'], 'weight': 460, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 40, 'gender_rate': 4, 'capture_rate': 15, 'color': 'white', 'shape': 'bug-wings', 'habitat': None, 'generation': 'generation-v', 'growth_rate': 'slow', 'egg_groups': ['bug'], 'names': {'ja-Hrkt': 'ウルガモス', 'ko': '불카모스', 'zh-Hant': '火神蛾', 'fr': 'Pyrax', 'de': 'Ramoth', 'es': 'Volcarona', 'it': 'Volcarona', 'en': 'Volcarona', 'ja': 'ウルガモス', 'zh-Hans': '火神蛾'}, 'genera': {'ja-Hrkt': 'たいようポケモン', 'ko': '태양포켓몬', 'zh-Hant': '太陽寶可夢', 'fr': 'Pokémon Soleil', 'de': 'Sonne', 'es': 'Pokémon Sol', 'it': 'Pokémon Sole', 'en': 'Sun Pokémon', 'ja': 'たいようポケモン', 'zh-Hans': '太阳宝可梦'}}
	public class SpecieVolcarona : PokemonSpecie
	{
#nullable enable
		private static SpecieVolcarona? _instance = null;
#nullable restore
        public static SpecieVolcarona Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieVolcarona();
                }
                return _instance;
            }
        }

		public SpecieVolcarona() : base(
			"Volcarona",
			85, // HPs
			60, 65, // Attack & Defense
			135, 105, // Special Attack & Defense
			100			
		) {}
	}


	//Volcarona Pokemon Class
	public class Volcarona : Pokemon
	{

		public Volcarona(string nickname, int level)
		: base(
				637,
				SpecieVolcarona.Instance, // Pokemon Specie
				nickname, level,
				Bug.Instance, Fire.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Volcarona() : base(
			637,
			SpecieVolcarona.Instance, // Pokemon Specie
			Bug.Instance, Fire.Instance			
		) {}
	}
}