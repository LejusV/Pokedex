using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Remoraid Specie to store common natural stats of every {'abilities': ['hustle', 'sniper', 'moody'], 'base_experience': 60, 'height': 6, 'id': 223, 'moves': ['double-edge', 'supersonic', 'flamethrower', 'water-gun', 'hydro-pump', 'surf', 'ice-beam', 'blizzard', 'psybeam', 'bubble-beam', 'aurora-beam', 'hyper-beam', 'string-shot', 'thunder-wave', 'toxic', 'psychic', 'mimic', 'screech', 'double-team', 'defense-curl', 'haze', 'focus-energy', 'fire-blast', 'waterfall', 'swift', 'rest', 'substitute', 'thief', 'snore', 'curse', 'flail', 'protect', 'mud-slap', 'octazooka', 'icy-wind', 'lock-on', 'endure', 'swagger', 'attract', 'sleep-talk', 'return', 'frustration', 'hidden-power', 'rain-dance', 'sunny-day', 'whirlpool', 'facade', 'secret-power', 'dive', 'water-spout', 'signal-beam', 'bullet-seed', 'bounce', 'mud-shot', 'rock-blast', 'water-pulse', 'brine', 'natural-gift', 'seed-bomb', 'gunk-shot', 'captivate', 'charge-beam', 'smack-down', 'soak', 'acid-spray', 'entrainment', 'round', 'scald', 'incinerate', 'confide'], 'name': 'remoraid', 'stats': {'hp': 35, 'attack': 65, 'defense': 35, 'special-attack': 65, 'special-defense': 35, 'speed': 65}, 'types': ['water'], 'weight': 120, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 20, 'gender_rate': 4, 'capture_rate': 190, 'color': 'gray', 'shape': 'fish', 'habitat': 'sea', 'generation': 'generation-ii', 'growth_rate': 'medium', 'egg_groups': ['water1', 'water2'], 'names': {'ja-Hrkt': 'テッポウオ', 'roomaji': 'Teppouo', 'ko': '총어', 'zh-Hant': '鐵砲魚', 'fr': 'Rémoraid', 'de': 'Remoraid', 'es': 'Remoraid', 'it': 'Remoraid', 'en': 'Remoraid', 'ja': 'テッポウオ', 'zh-Hans': '铁炮鱼'}, 'genera': {'ja-Hrkt': 'ふんしゃポケモン', 'ko': '분사포켓몬', 'zh-Hant': '噴射寶可夢', 'fr': 'Pokémon Jet', 'de': 'Hochdruck', 'es': 'Pokémon Reactor', 'it': 'Pokémon Jet', 'en': 'Jet Pokémon', 'ja': 'ふんしゃポケモン', 'zh-Hans': '喷射宝可梦'}}
	public class SpecieRemoraid : PokemonSpecie
	{
#nullable enable
		private static SpecieRemoraid? _instance = null;
#nullable restore
        public static SpecieRemoraid Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieRemoraid();
                }
                return _instance;
            }
        }

		public SpecieRemoraid() : base(
			"Remoraid",
			35, // HPs
			65, 35, // Attack & Defense
			65, 35, // Special Attack & Defense
			65			
		) {}
	}


	//Remoraid Pokemon Class
	public class Remoraid : Pokemon
	{

		public Remoraid(string nickname, int level) : base(
			223,
			SpecieRemoraid.Instance, // Pokemon Specie
			nickname, level,
			Water.Instance			
		) {}

		public Remoraid() : base(
			223,
			SpecieRemoraid.Instance, // Pokemon Specie
			Water.Instance			
		) {}
	}
}