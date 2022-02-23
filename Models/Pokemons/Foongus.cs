using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Foongus Specie to store common natural stats of every {'abilities': ['effect-spore', 'regenerator'], 'base_experience': 59, 'height': 2, 'id': 590, 'moves': ['body-slam', 'absorb', 'mega-drain', 'growth', 'solar-beam', 'poison-powder', 'stun-spore', 'toxic', 'double-team', 'defense-curl', 'bide', 'spore', 'flash', 'rest', 'substitute', 'snore', 'protect', 'feint-attack', 'sludge-bomb', 'giga-drain', 'endure', 'rollout', 'swagger', 'attract', 'sleep-talk', 'return', 'frustration', 'sweet-scent', 'synthesis', 'hidden-power', 'rain-dance', 'sunny-day', 'facade', 'nature-power', 'ingrain', 'secret-power', 'astonish', 'payback', 'gastro-acid', 'worry-seed', 'seed-bomb', 'energy-ball', 'grass-knot', 'venoshock', 'rage-powder', 'foul-play', 'after-you', 'round', 'clear-smog', 'confide'], 'name': 'foongus', 'stats': {'hp': 69, 'attack': 55, 'defense': 45, 'special-attack': 55, 'special-defense': 55, 'speed': 15}, 'types': ['grass', 'poison'], 'weight': 10, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 20, 'gender_rate': 4, 'capture_rate': 190, 'color': 'white', 'shape': 'arms', 'habitat': None, 'generation': 'generation-v', 'growth_rate': 'medium', 'egg_groups': ['plant'], 'names': {'ja-Hrkt': 'タマゲタケ', 'ko': '깜놀버슬', 'zh-Hant': '哎呀球菇', 'fr': 'Trompignon', 'de': 'Tarnpignon', 'es': 'Foongus', 'it': 'Foongus', 'en': 'Foongus', 'ja': 'タマゲタケ', 'zh-Hans': '哎呀球菇'}, 'genera': {'ja-Hrkt': 'きのこポケモン', 'ko': '버섯포켓몬', 'zh-Hant': '蘑菇寶可夢', 'fr': 'Pokémon Champignon', 'de': 'Pilz', 'es': 'Pokémon Hongo', 'it': 'Pokémon Fungo', 'en': 'Mushroom Pokémon', 'ja': 'きのこポケモン', 'zh-Hans': '蘑菇宝可梦'}}
	public class SpecieFoongus : PokemonSpecie
	{
#nullable enable
		private static SpecieFoongus? _instance = null;
#nullable restore
        public static SpecieFoongus Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieFoongus();
                }
                return _instance;
            }
        }

		public SpecieFoongus() : base(
			"Foongus",
			69, // HPs
			55, 45, // Attack & Defense
			55, 55, // Special Attack & Defense
			15			
		) {}
	}


	//Foongus Pokemon Class
	public class Foongus : Pokemon
	{

		public Foongus(string nickname, int level) : base(
			590,
			SpecieFoongus.Instance, // Pokemon Specie
			nickname, level,
			Grass.Instance, Poison.Instance			
		) {}

		public Foongus() : base(
			590,
			SpecieFoongus.Instance, // Pokemon Specie
			Grass.Instance, Poison.Instance			
		) {}
	}
}