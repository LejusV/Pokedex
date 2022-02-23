using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Florges Specie to store common natural stats of every {'abilities': ['flower-veil', 'symbiosis'], 'base_experience': 248, 'height': 11, 'id': 671, 'moves': ['hyper-beam', 'solar-beam', 'petal-dance', 'toxic', 'psychic', 'double-team', 'light-screen', 'flash', 'rest', 'substitute', 'snore', 'protect', 'giga-drain', 'swagger', 'attract', 'sleep-talk', 'heal-bell', 'return', 'frustration', 'safeguard', 'synthesis', 'hidden-power', 'rain-dance', 'sunny-day', 'facade', 'nature-power', 'helping-hand', 'wish', 'magic-coat', 'endeavor', 'secret-power', 'aromatherapy', 'covet', 'magical-leaf', 'calm-mind', 'lucky-chant', 'worry-seed', 'seed-bomb', 'energy-ball', 'giga-impact', 'grass-knot', 'after-you', 'round', 'echoed-voice', 'petal-blizzard', 'disarming-voice', 'flower-shield', 'grassy-terrain', 'misty-terrain', 'moonblast', 'confide', 'dazzling-gleam'], 'name': 'florges', 'stats': {'hp': 78, 'attack': 65, 'defense': 68, 'special-attack': 112, 'special-defense': 154, 'speed': 75}, 'types': ['fairy'], 'weight': 100, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 20, 'gender_rate': 8, 'capture_rate': 45, 'color': 'white', 'shape': 'arms', 'habitat': None, 'generation': 'generation-vi', 'growth_rate': 'medium', 'egg_groups': ['fairy'], 'names': {'ja-Hrkt': 'フラージェス', 'ko': '플라제스', 'zh-Hant': '花潔夫人', 'fr': 'Florges', 'de': 'Florges', 'es': 'Florges', 'it': 'Florges', 'en': 'Florges', 'ja': 'フラージェス', 'zh-Hans': '花洁夫人'}, 'genera': {'ja-Hrkt': 'ガーデンポケモン', 'ko': '가든포켓몬', 'zh-Hant': '花園寶可夢', 'fr': 'Pokémon Jardin', 'de': 'Garten', 'es': 'Pokémon Jardín', 'it': 'Pokémon Giardino', 'en': 'Garden Pokémon', 'ja': 'ガーデンポケモン', 'zh-Hans': '花园宝可梦'}}
	public class SpecieFlorges : PokemonSpecie
	{
#nullable enable
		private static SpecieFlorges? _instance = null;
#nullable restore
        public static SpecieFlorges Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieFlorges();
                }
                return _instance;
            }
        }

		public SpecieFlorges() : base(
			"Florges",
			78, // HPs
			65, 68, // Attack & Defense
			112, 154, // Special Attack & Defense
			75			
		) {}
	}


	//Florges Pokemon Class
	public class Florges : Pokemon
	{

		public Florges(string nickname, int level) : base(
			671,
			SpecieFlorges.Instance, // Pokemon Specie
			nickname, level,
			Fairy.Instance			
		) {}

		public Florges() : base(
			671,
			SpecieFlorges.Instance, // Pokemon Specie
			Fairy.Instance			
		) {}
	}
}