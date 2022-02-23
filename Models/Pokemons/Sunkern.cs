using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Sunkern Specie to store common natural stats of every {'abilities': ['chlorophyll', 'solar-power', 'early-bird'], 'base_experience': 36, 'height': 3, 'id': 191, 'moves': ['swords-dance', 'cut', 'double-edge', 'absorb', 'mega-drain', 'leech-seed', 'growth', 'razor-leaf', 'solar-beam', 'toxic', 'mimic', 'double-team', 'light-screen', 'bide', 'flash', 'rest', 'substitute', 'snore', 'curse', 'protect', 'sludge-bomb', 'giga-drain', 'endure', 'swagger', 'attract', 'sleep-talk', 'return', 'frustration', 'safeguard', 'encore', 'sweet-scent', 'morning-sun', 'synthesis', 'hidden-power', 'sunny-day', 'uproar', 'facade', 'nature-power', 'helping-hand', 'ingrain', 'endeavor', 'secret-power', 'grass-whistle', 'bullet-seed', 'natural-gift', 'worry-seed', 'seed-bomb', 'energy-ball', 'earth-power', 'captivate', 'grass-knot', 'after-you', 'round', 'grassy-terrain', 'confide'], 'name': 'sunkern', 'stats': {'hp': 30, 'attack': 30, 'defense': 30, 'special-attack': 30, 'special-defense': 30, 'speed': 30}, 'types': ['grass'], 'weight': 18, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 20, 'gender_rate': 4, 'capture_rate': 235, 'color': 'yellow', 'shape': 'ball', 'habitat': 'grassland', 'generation': 'generation-ii', 'growth_rate': 'medium-slow', 'egg_groups': ['plant'], 'names': {'ja-Hrkt': 'ヒマナッツ', 'roomaji': 'Himanuts', 'ko': '해너츠', 'zh-Hant': '向日種子', 'fr': 'Tournegrin', 'de': 'Sonnkern', 'es': 'Sunkern', 'it': 'Sunkern', 'en': 'Sunkern', 'ja': 'ヒマナッツ', 'zh-Hans': '向日种子'}, 'genera': {'ja-Hrkt': 'たねポケモン', 'ko': '씨앗포켓몬', 'zh-Hant': '種子寶可夢', 'fr': 'Pokémon Graine', 'de': 'Samen', 'es': 'Pokémon Semilla', 'it': 'Pokémon Seme', 'en': 'Seed Pokémon', 'ja': 'たねポケモン', 'zh-Hans': '种子宝可梦'}}
	public class SpecieSunkern : PokemonSpecie
	{
#nullable enable
		private static SpecieSunkern? _instance = null;
#nullable restore
        public static SpecieSunkern Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieSunkern();
                }
                return _instance;
            }
        }

		public SpecieSunkern() : base(
			"Sunkern",
			30, // HPs
			30, 30, // Attack & Defense
			30, 30, // Special Attack & Defense
			30			
		) {}
	}


	//Sunkern Pokemon Class
	public class Sunkern : Pokemon
	{

		public Sunkern(string nickname, int level) : base(
			191,
			SpecieSunkern.Instance, // Pokemon Specie
			nickname, level,
			Grass.Instance			
		) {}

		public Sunkern() : base(
			191,
			SpecieSunkern.Instance, // Pokemon Specie
			Grass.Instance			
		) {}
	}
}