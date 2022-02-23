using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Swirlix Specie to store common natural stats of every {'abilities': ['sweet-veil', 'unburden'], 'base_experience': 68, 'height': 4, 'id': 684, 'moves': ['tackle', 'flamethrower', 'surf', 'thunderbolt', 'toxic', 'psychic', 'double-team', 'light-screen', 'dream-eater', 'flash', 'rest', 'substitute', 'thief', 'snore', 'cotton-spore', 'protect', 'belly-drum', 'swagger', 'attract', 'sleep-talk', 'heal-bell', 'return', 'frustration', 'safeguard', 'sweet-scent', 'hidden-power', 'rain-dance', 'sunny-day', 'psych-up', 'facade', 'helping-hand', 'wish', 'magic-coat', 'yawn', 'endeavor', 'secret-power', 'aromatherapy', 'fake-tears', 'covet', 'calm-mind', 'gastro-acid', 'copycat', 'energy-ball', 'after-you', 'round', 'cotton-guard', 'sticky-web', 'draining-kiss', 'play-rough', 'fairy-wind', 'play-nice', 'confide', 'dazzling-gleam'], 'name': 'swirlix', 'stats': {'hp': 62, 'attack': 48, 'defense': 66, 'special-attack': 59, 'special-defense': 57, 'speed': 49}, 'types': ['fairy'], 'weight': 35, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 20, 'gender_rate': 4, 'capture_rate': 200, 'color': 'white', 'shape': 'legs', 'habitat': None, 'generation': 'generation-vi', 'growth_rate': 'medium', 'egg_groups': ['fairy'], 'names': {'ja-Hrkt': 'ペロッパフ', 'ko': '나룸퍼프', 'zh-Hant': '綿綿泡芙', 'fr': 'Sucroquin', 'de': 'Flauschling', 'es': 'Swirlix', 'it': 'Swirlix', 'en': 'Swirlix', 'ja': 'ペロッパフ', 'zh-Hans': '绵绵泡芙'}, 'genera': {'ja-Hrkt': 'わたあめポケモン', 'ko': '솜사탕포켓몬', 'zh-Hant': '棉花糖寶可夢', 'fr': 'Pokémon Confiserie', 'de': 'Zuckerwatte', 'es': 'Pokémon Chuchería', 'it': 'Pokémon Zuccherino', 'en': 'Cotton Candy Pokémon', 'ja': 'わたあめポケモン', 'zh-Hans': '棉花糖宝可梦'}}
	public class SpecieSwirlix : PokemonSpecie
	{
#nullable enable
		private static SpecieSwirlix? _instance = null;
#nullable restore
        public static SpecieSwirlix Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieSwirlix();
                }
                return _instance;
            }
        }

		public SpecieSwirlix() : base(
			"Swirlix",
			62, // HPs
			48, 66, // Attack & Defense
			59, 57, // Special Attack & Defense
			49			
		) {}
	}


	//Swirlix Pokemon Class
	public class Swirlix : Pokemon
	{

		public Swirlix(string nickname, int level) : base(
			684,
			SpecieSwirlix.Instance, // Pokemon Specie
			nickname, level,
			Fairy.Instance			
		) {}

		public Swirlix() : base(
			684,
			SpecieSwirlix.Instance, // Pokemon Specie
			Fairy.Instance			
		) {}
	}
}