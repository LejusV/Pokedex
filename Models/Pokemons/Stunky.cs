using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Stunky Specie to store common natural stats of every {'abilities': ['stench', 'aftermath', 'keen-eye'], 'base_experience': 66, 'height': 4, 'id': 434, 'moves': ['scratch', 'cut', 'headbutt', 'double-edge', 'leer', 'bite', 'roar', 'flamethrower', 'dig', 'toxic', 'screech', 'double-team', 'smokescreen', 'haze', 'focus-energy', 'smog', 'fire-blast', 'swift', 'poison-gas', 'explosion', 'fury-swipes', 'rest', 'slash', 'substitute', 'thief', 'snore', 'protect', 'scary-face', 'sludge-bomb', 'mud-slap', 'endure', 'swagger', 'fury-cutter', 'attract', 'sleep-talk', 'return', 'frustration', 'pursuit', 'iron-tail', 'hidden-power', 'rain-dance', 'sunny-day', 'crunch', 'shadow-ball', 'rock-smash', 'torment', 'memento', 'facade', 'taunt', 'snatch', 'secret-power', 'astonish', 'natural-gift', 'feint', 'payback', 'punishment', 'sucker-punch', 'dark-pulse', 'night-slash', 'shadow-claw', 'defog', 'captivate', 'hone-claws', 'venoshock', 'flame-burst', 'acid-spray', 'foul-play', 'round', 'incinerate', 'snarl', 'belch', 'play-rough', 'confide', 'venom-drench'], 'name': 'stunky', 'stats': {'hp': 63, 'attack': 63, 'defense': 47, 'special-attack': 41, 'special-defense': 41, 'speed': 74}, 'types': ['poison', 'dark'], 'weight': 192, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 20, 'gender_rate': 4, 'capture_rate': 225, 'color': 'purple', 'shape': 'quadruped', 'habitat': None, 'generation': 'generation-iv', 'growth_rate': 'medium', 'egg_groups': ['ground'], 'names': {'ja-Hrkt': 'スカンプー', 'roomaji': 'Skunpoo', 'ko': '스컹뿡', 'zh-Hant': '臭鼬噗', 'fr': 'Moufouette', 'de': 'Skunkapuh', 'es': 'Stunky', 'it': 'Stunky', 'en': 'Stunky', 'ja': 'スカンプー', 'zh-Hans': '臭鼬噗'}, 'genera': {'ja-Hrkt': 'スカンクポケモン', 'ko': '스컹크포켓몬', 'zh-Hant': '臭鼬寶可夢', 'fr': 'Pokémon Moufette', 'de': 'Stinktier', 'es': 'Pokémon Mofeta', 'it': 'Pokémon Moffetta', 'en': 'Skunk Pokémon', 'ja': 'スカンクポケモン', 'zh-Hans': '臭鼬宝可梦'}}
	public class SpecieStunky : PokemonSpecie
	{
#nullable enable
		private static SpecieStunky? _instance = null;
#nullable restore
        public static SpecieStunky Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieStunky();
                }
                return _instance;
            }
        }

		public SpecieStunky() : base(
			"Stunky",
			63, // HPs
			63, 47, // Attack & Defense
			41, 41, // Special Attack & Defense
			74			
		) {}
	}


	//Stunky Pokemon Class
	public class Stunky : Pokemon
	{

		public Stunky(string nickname, int level)
		: base(
				434,
				SpecieStunky.Instance, // Pokemon Specie
				nickname, level,
				Poison.Instance, Dark.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Stunky(int level)
		: base(
				434,
				SpecieStunky.Instance, // Pokemon Specie
				"Stunky", level,
				Poison.Instance, Dark.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Stunky() : base(
			434,
			SpecieStunky.Instance, // Pokemon Specie
			Poison.Instance, Dark.Instance			
		) {}
	}
}