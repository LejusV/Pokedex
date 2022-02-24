using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Comfey Specie to store common natural stats of every {'abilities': ['flower-veil', 'triage', 'natural-cure'], 'base_experience': 170, 'height': 1, 'id': 764, 'moves': ['vine-whip', 'wrap', 'hyper-beam', 'leech-seed', 'growth', 'solar-beam', 'petal-dance', 'toxic', 'double-team', 'light-screen', 'amnesia', 'rest', 'substitute', 'thief', 'protect', 'sweet-kiss', 'endure', 'swagger', 'attract', 'sleep-talk', 'return', 'frustration', 'safeguard', 'sweet-scent', 'synthesis', 'hidden-power', 'sunny-day', 'psych-up', 'facade', 'nature-power', 'taunt', 'helping-hand', 'aromatherapy', 'magical-leaf', 'calm-mind', 'natural-gift', 'u-turn', 'fling', 'lucky-chant', 'energy-ball', 'trick-room', 'grass-knot', 'after-you', 'round', 'echoed-voice', 'acrobatics', 'petal-blizzard', 'draining-kiss', 'flower-shield', 'grassy-terrain', 'play-rough', 'confide', 'dazzling-gleam', 'floral-healing'], 'name': 'comfey', 'stats': {'hp': 51, 'attack': 52, 'defense': 90, 'special-attack': 82, 'special-defense': 110, 'speed': 100}, 'types': ['fairy'], 'weight': 3, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 20, 'gender_rate': 6, 'capture_rate': 60, 'color': 'green', 'shape': 'ball', 'habitat': None, 'generation': 'generation-vii', 'growth_rate': 'fast', 'egg_groups': ['plant'], 'names': {'ja-Hrkt': 'キュワワー', 'ko': '큐아링', 'zh-Hant': '花療環環', 'fr': 'Guérilande', 'de': 'Curelei', 'es': 'Comfey', 'it': 'Comfey', 'en': 'Comfey', 'ja': 'キュワワー', 'zh-Hans': '花疗环环'}, 'genera': {'ja-Hrkt': 'はなつみポケモン', 'ko': '꽃따기포켓몬', 'zh-Hant': '摘花寶可夢', 'fr': 'Pokémon Tressefleur', 'de': 'Blumenkranz', 'es': 'Pokémon Recogeflores', 'it': 'Pokémon Ghirlanda', 'en': 'Posy Picker Pokémon', 'ja': 'はなつみポケモン', 'zh-Hans': '摘花宝可梦'}}
	public class SpecieComfey : PokemonSpecie
	{
#nullable enable
		private static SpecieComfey? _instance = null;
#nullable restore
        public static SpecieComfey Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieComfey();
                }
                return _instance;
            }
        }

		public SpecieComfey() : base(
			"Comfey",
			51, // HPs
			52, 90, // Attack & Defense
			82, 110, // Special Attack & Defense
			100			
		) {}
	}


	//Comfey Pokemon Class
	public class Comfey : Pokemon
	{

		public Comfey(string nickname, int level)
		: base(
				764,
				SpecieComfey.Instance, // Pokemon Specie
				nickname, level,
				Fairy.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Comfey() : base(
			764,
			SpecieComfey.Instance, // Pokemon Specie
			Fairy.Instance			
		) {}
	}
}