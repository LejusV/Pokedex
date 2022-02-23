using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Mantine Specie to store common natural stats of every {'abilities': ['swift-swim', 'water-absorb', 'water-veil'], 'base_experience': 170, 'height': 21, 'id': 226, 'moves': ['wing-attack', 'slam', 'headbutt', 'tackle', 'body-slam', 'take-down', 'double-edge', 'supersonic', 'hydro-pump', 'surf', 'ice-beam', 'blizzard', 'psybeam', 'bubble-beam', 'hyper-beam', 'string-shot', 'earthquake', 'toxic', 'agility', 'mimic', 'double-team', 'confuse-ray', 'haze', 'waterfall', 'swift', 'amnesia', 'bubble', 'splash', 'rest', 'rock-slide', 'substitute', 'snore', 'curse', 'protect', 'mud-slap', 'icy-wind', 'endure', 'swagger', 'attract', 'sleep-talk', 'return', 'frustration', 'hidden-power', 'twister', 'rain-dance', 'mirror-coat', 'whirlpool', 'hail', 'facade', 'helping-hand', 'secret-power', 'dive', 'mud-sport', 'air-cutter', 'rock-tomb', 'signal-beam', 'bullet-seed', 'aerial-ace', 'bounce', 'water-sport', 'water-pulse', 'roost', 'brine', 'natural-gift', 'tailwind', 'aqua-ring', 'aqua-tail', 'seed-bomb', 'air-slash', 'giga-impact', 'defog', 'gunk-shot', 'iron-head', 'captivate', 'wide-guard', 'round', 'scald', 'acrobatics', 'bulldoze', 'confide'], 'name': 'mantine', 'stats': {'hp': 85, 'attack': 40, 'defense': 70, 'special-attack': 80, 'special-defense': 140, 'speed': 70}, 'types': ['water', 'flying'], 'weight': 2200, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 25, 'gender_rate': 4, 'capture_rate': 25, 'color': 'purple', 'shape': 'wings', 'habitat': 'sea', 'generation': 'generation-ii', 'growth_rate': 'slow', 'egg_groups': ['water1'], 'names': {'ja-Hrkt': 'マンタイン', 'roomaji': 'Mantain', 'ko': '만타인', 'zh-Hant': '巨翅飛魚', 'fr': 'Démanta', 'de': 'Mantax', 'es': 'Mantine', 'it': 'Mantine', 'en': 'Mantine', 'ja': 'マンタイン', 'zh-Hans': '巨翅飞鱼'}, 'genera': {'ja-Hrkt': 'カイトポケモン', 'ko': '연포켓몬', 'zh-Hant': '風箏寶可夢', 'fr': 'Pokémon Cervolant', 'de': 'Flugrochen', 'es': 'Pokémon Milano', 'it': 'Pokémon Aquilone', 'en': 'Kite Pokémon', 'ja': 'カイトポケモン', 'zh-Hans': '风筝宝可梦'}}
	public class SpecieMantine : PokemonSpecie
	{
#nullable enable
		private static SpecieMantine? _instance = null;
#nullable restore
        public static SpecieMantine Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieMantine();
                }
                return _instance;
            }
        }

		public SpecieMantine() : base(
			"Mantine",
			85, // HPs
			40, 70, // Attack & Defense
			80, 140, // Special Attack & Defense
			70			
		) {}
	}


	//Mantine Pokemon Class
	public class Mantine : Pokemon
	{

		public Mantine(string nickname, int level) : base(
			226,
			SpecieMantine.Instance, // Pokemon Specie
			nickname, level,
			Water.Instance, Flying.Instance			
		) {}

		public Mantine() : base(
			226,
			SpecieMantine.Instance, // Pokemon Specie
			Water.Instance, Flying.Instance			
		) {}
	}
}