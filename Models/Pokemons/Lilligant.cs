using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Lilligant Specie to store common natural stats of every {'abilities': ['chlorophyll', 'own-tempo', 'leaf-guard'], 'base_experience': 168, 'height': 11, 'id': 549, 'moves': ['swords-dance', 'cut', 'hyper-beam', 'mega-drain', 'leech-seed', 'growth', 'solar-beam', 'petal-dance', 'toxic', 'double-team', 'light-screen', 'dream-eater', 'flash', 'rest', 'substitute', 'snore', 'protect', 'giga-drain', 'swagger', 'attract', 'sleep-talk', 'heal-bell', 'return', 'frustration', 'safeguard', 'synthesis', 'hidden-power', 'sunny-day', 'facade', 'nature-power', 'helping-hand', 'role-play', 'secret-power', 'teeter-dance', 'covet', 'worry-seed', 'seed-bomb', 'energy-ball', 'giga-impact', 'grass-knot', 'quiver-dance', 'after-you', 'round', 'petal-blizzard', 'confide'], 'name': 'lilligant', 'stats': {'hp': 70, 'attack': 60, 'defense': 75, 'special-attack': 110, 'special-defense': 75, 'speed': 90}, 'types': ['grass'], 'weight': 163, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 20, 'gender_rate': 8, 'capture_rate': 75, 'color': 'green', 'shape': 'blob', 'habitat': None, 'generation': 'generation-v', 'growth_rate': 'medium', 'egg_groups': ['plant'], 'names': {'ja-Hrkt': 'ドレディア', 'ko': '드레디어', 'zh-Hant': '裙兒小姐', 'fr': 'Fragilady', 'de': 'Dressella', 'es': 'Lilligant', 'it': 'Lilligant', 'en': 'Lilligant', 'ja': 'ドレディア', 'zh-Hans': '裙儿小姐'}, 'genera': {'ja-Hrkt': 'はなかざりポケモン', 'ko': '꽃장식포켓몬', 'zh-Hant': '花飾寶可夢', 'fr': 'Pokémon Chef-Fleur', 'de': 'Blumenzier', 'es': 'Pokémon Adornofloral', 'it': 'Pokémon Fiorfronzolo', 'en': 'Flowering Pokémon', 'ja': 'はなかざりポケモン', 'zh-Hans': '花饰宝可梦'}}
	public class SpecieLilligant : PokemonSpecie
	{
#nullable enable
		private static SpecieLilligant? _instance = null;
#nullable restore
        public static SpecieLilligant Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieLilligant();
                }
                return _instance;
            }
        }

		public SpecieLilligant() : base(
			"Lilligant",
			70, // HPs
			60, 75, // Attack & Defense
			110, 75, // Special Attack & Defense
			90			
		) {}
	}


	//Lilligant Pokemon Class
	public class Lilligant : Pokemon
	{

		public Lilligant(string nickname, int level) : base(
			549,
			SpecieLilligant.Instance, // Pokemon Specie
			nickname, level,
			Grass.Instance			
		) {}

		public Lilligant() : base(
			549,
			SpecieLilligant.Instance, // Pokemon Specie
			Grass.Instance			
		) {}
	}
}