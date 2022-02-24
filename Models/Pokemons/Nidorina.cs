using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Nidorina Specie to store common natural stats of every {'abilities': ['poison-point', 'rivalry', 'hustle'], 'base_experience': 128, 'height': 8, 'id': 30, 'moves': ['scratch', 'cut', 'double-kick', 'headbutt', 'horn-drill', 'tackle', 'body-slam', 'take-down', 'double-edge', 'tail-whip', 'poison-sting', 'bite', 'growl', 'water-gun', 'ice-beam', 'blizzard', 'bubble-beam', 'counter', 'strength', 'thunderbolt', 'thunder', 'dig', 'toxic', 'rage', 'mimic', 'double-team', 'defense-curl', 'reflect', 'bide', 'skull-bash', 'fury-swipes', 'rest', 'super-fang', 'substitute', 'thief', 'snore', 'curse', 'protect', 'sludge-bomb', 'mud-slap', 'detect', 'endure', 'swagger', 'attract', 'sleep-talk', 'return', 'frustration', 'iron-tail', 'hidden-power', 'rain-dance', 'sunny-day', 'crunch', 'rock-smash', 'flatter', 'facade', 'helping-hand', 'secret-power', 'poison-fang', 'aerial-ace', 'shock-wave', 'water-pulse', 'natural-gift', 'toxic-spikes', 'poison-jab', 'shadow-claw', 'captivate', 'hone-claws', 'venoshock', 'round', 'echoed-voice', 'confide'], 'name': 'nidorina', 'stats': {'hp': 70, 'attack': 62, 'defense': 67, 'special-attack': 55, 'special-defense': 55, 'speed': 56}, 'types': ['poison'], 'weight': 200, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 20, 'gender_rate': 8, 'capture_rate': 120, 'color': 'blue', 'shape': 'quadruped', 'habitat': 'grassland', 'generation': 'generation-i', 'growth_rate': 'medium-slow', 'egg_groups': ['no-eggs'], 'names': {'ja-Hrkt': 'ニドリーナ', 'roomaji': 'Nidorina', 'ko': '니드리나', 'zh-Hant': '尼多娜', 'fr': 'Nidorina', 'de': 'Nidorina', 'es': 'Nidorina', 'it': 'Nidorina', 'en': 'Nidorina', 'ja': 'ニドリーナ', 'zh-Hans': '尼多娜'}, 'genera': {'ja-Hrkt': 'どくばりポケモン', 'ko': '독침포켓몬', 'zh-Hant': '毒針寶可夢', 'fr': 'Pokémon Vénépic', 'de': 'Giftdorn', 'es': 'Pokémon Pin Veneno', 'it': 'Pokémon Velenago', 'en': 'Poison Pin Pokémon', 'ja': 'どくばりポケモン', 'zh-Hans': '毒针宝可梦'}}
	public class SpecieNidorina : PokemonSpecie
	{
#nullable enable
		private static SpecieNidorina? _instance = null;
#nullable restore
        public static SpecieNidorina Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieNidorina();
                }
                return _instance;
            }
        }

		public SpecieNidorina() : base(
			"Nidorina",
			70, // HPs
			62, 67, // Attack & Defense
			55, 55, // Special Attack & Defense
			56			
		) {}
	}


	//Nidorina Pokemon Class
	public class Nidorina : Pokemon
	{

		public Nidorina(string nickname, int level)
		: base(
				30,
				SpecieNidorina.Instance, // Pokemon Specie
				nickname, level,
				Poison.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Nidorina() : base(
			30,
			SpecieNidorina.Instance, // Pokemon Specie
			Poison.Instance			
		) {}
	}
}