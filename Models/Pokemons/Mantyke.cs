using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Mantyke Specie to store common natural stats of every {'abilities': ['swift-swim', 'water-absorb', 'water-veil'], 'base_experience': 69, 'height': 10, 'id': 458, 'moves': ['wing-attack', 'slam', 'headbutt', 'tackle', 'take-down', 'supersonic', 'hydro-pump', 'surf', 'ice-beam', 'blizzard', 'bubble-beam', 'earthquake', 'toxic', 'agility', 'double-team', 'confuse-ray', 'haze', 'waterfall', 'swift', 'amnesia', 'bubble', 'splash', 'rest', 'rock-slide', 'substitute', 'snore', 'protect', 'mud-slap', 'icy-wind', 'endure', 'swagger', 'attract', 'sleep-talk', 'return', 'frustration', 'hidden-power', 'twister', 'rain-dance', 'mirror-coat', 'whirlpool', 'hail', 'facade', 'helping-hand', 'secret-power', 'dive', 'mud-sport', 'air-cutter', 'signal-beam', 'aerial-ace', 'bounce', 'water-sport', 'water-pulse', 'natural-gift', 'tailwind', 'aqua-ring', 'air-slash', 'captivate', 'wide-guard', 'round', 'scald', 'acrobatics', 'bulldoze', 'confide'], 'name': 'mantyke', 'stats': {'hp': 45, 'attack': 20, 'defense': 50, 'special-attack': 60, 'special-defense': 120, 'speed': 50}, 'types': ['water', 'flying'], 'weight': 650, 'is_baby': True, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 25, 'gender_rate': 4, 'capture_rate': 25, 'color': 'blue', 'shape': 'wings', 'habitat': None, 'generation': 'generation-iv', 'growth_rate': 'slow', 'egg_groups': ['no-eggs'], 'names': {'ja-Hrkt': 'タマンタ', 'roomaji': 'Tamanta', 'ko': '타만타', 'zh-Hant': '小球飛魚', 'fr': 'Babimanta', 'de': 'Mantirps', 'es': 'Mantyke', 'it': 'Mantyke', 'en': 'Mantyke', 'ja': 'タマンタ', 'zh-Hans': '小球飞鱼'}, 'genera': {'ja-Hrkt': 'カイトポケモン', 'ko': '연포켓몬', 'zh-Hant': '風箏寶可夢', 'fr': 'Pokémon Cervolant', 'de': 'Flugrochen', 'es': 'Pokémon Milano', 'it': 'Pokémon Aquilone', 'en': 'Kite Pokémon', 'ja': 'カイトポケモン', 'zh-Hans': '风筝宝可梦'}}
	public class SpecieMantyke : PokemonSpecie
	{
#nullable enable
		private static SpecieMantyke? _instance = null;
#nullable restore
        public static SpecieMantyke Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieMantyke();
                }
                return _instance;
            }
        }

		public SpecieMantyke() : base(
			"Mantyke",
			45, // HPs
			20, 50, // Attack & Defense
			60, 120, // Special Attack & Defense
			50			
		) {}
	}


	//Mantyke Pokemon Class
	public class Mantyke : Pokemon
	{

		public Mantyke(string nickname, int level) : base(
			458,
			SpecieMantyke.Instance, // Pokemon Specie
			nickname, level,
			Water.Instance, Flying.Instance			
		) {}

		public Mantyke() : base(
			458,
			SpecieMantyke.Instance, // Pokemon Specie
			Water.Instance, Flying.Instance			
		) {}
	}
}