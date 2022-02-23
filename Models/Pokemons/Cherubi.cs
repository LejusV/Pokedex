using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Cherubi Specie to store common natural stats of every {'abilities': ['chlorophyll'], 'base_experience': 55, 'height': 4, 'id': 420, 'moves': ['swords-dance', 'tackle', 'take-down', 'leech-seed', 'growth', 'razor-leaf', 'solar-beam', 'toxic', 'double-team', 'defense-curl', 'flash', 'rest', 'substitute', 'snore', 'protect', 'giga-drain', 'endure', 'rollout', 'swagger', 'attract', 'sleep-talk', 'return', 'frustration', 'safeguard', 'sweet-scent', 'morning-sun', 'synthesis', 'hidden-power', 'sunny-day', 'facade', 'nature-power', 'helping-hand', 'secret-power', 'weather-ball', 'aromatherapy', 'grass-whistle', 'tickle', 'bullet-seed', 'magical-leaf', 'healing-wish', 'natural-gift', 'lucky-chant', 'worry-seed', 'seed-bomb', 'energy-ball', 'captivate', 'grass-knot', 'round', 'heal-pulse', 'petal-blizzard', 'flower-shield', 'grassy-terrain', 'confide', 'dazzling-gleam'], 'name': 'cherubi', 'stats': {'hp': 45, 'attack': 35, 'defense': 45, 'special-attack': 62, 'special-defense': 53, 'speed': 35}, 'types': ['grass'], 'weight': 33, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 20, 'gender_rate': 4, 'capture_rate': 190, 'color': 'pink', 'shape': 'heads', 'habitat': None, 'generation': 'generation-iv', 'growth_rate': 'medium', 'egg_groups': ['fairy', 'plant'], 'names': {'ja-Hrkt': 'チェリンボ', 'roomaji': 'Cherinbo', 'ko': '체리버', 'zh-Hant': '櫻花寶', 'fr': 'Ceribou', 'de': 'Kikugi', 'es': 'Cherubi', 'it': 'Cherubi', 'en': 'Cherubi', 'ja': 'チェリンボ', 'zh-Hans': '樱花宝'}, 'genera': {'ja-Hrkt': 'さくらんぼポケモン', 'ko': '버찌포켓몬', 'zh-Hant': '櫻桃寶可夢', 'fr': 'Pokémon Cerise', 'de': 'Kirsche', 'es': 'Pokémon Cereza', 'it': 'Pokémon Ciliegia', 'en': 'Cherry Pokémon', 'ja': 'さくらんぼポケモン', 'zh-Hans': '樱桃宝可梦'}}
	public class SpecieCherubi : PokemonSpecie
	{
#nullable enable
		private static SpecieCherubi? _instance = null;
#nullable restore
        public static SpecieCherubi Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieCherubi();
                }
                return _instance;
            }
        }

		public SpecieCherubi() : base(
			"Cherubi",
			45, // HPs
			35, 45, // Attack & Defense
			62, 53, // Special Attack & Defense
			35			
		) {}
	}


	//Cherubi Pokemon Class
	public class Cherubi : Pokemon
	{

		public Cherubi(string nickname, int level) : base(
			420,
			SpecieCherubi.Instance, // Pokemon Specie
			nickname, level,
			Grass.Instance			
		) {}

		public Cherubi() : base(
			420,
			SpecieCherubi.Instance, // Pokemon Specie
			Grass.Instance			
		) {}
	}
}