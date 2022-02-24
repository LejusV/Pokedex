using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Skuntank Specie to store common natural stats of every {'abilities': ['stench', 'aftermath', 'keen-eye'], 'base_experience': 168, 'height': 10, 'id': 435, 'moves': ['scratch', 'cut', 'headbutt', 'bite', 'roar', 'flamethrower', 'hyper-beam', 'strength', 'dig', 'toxic', 'screech', 'double-team', 'smokescreen', 'focus-energy', 'fire-blast', 'swift', 'poison-gas', 'explosion', 'fury-swipes', 'rest', 'slash', 'substitute', 'thief', 'snore', 'protect', 'sludge-bomb', 'mud-slap', 'endure', 'swagger', 'fury-cutter', 'attract', 'sleep-talk', 'return', 'frustration', 'iron-tail', 'hidden-power', 'rain-dance', 'sunny-day', 'shadow-ball', 'rock-smash', 'torment', 'memento', 'facade', 'taunt', 'snatch', 'secret-power', 'natural-gift', 'feint', 'payback', 'sucker-punch', 'poison-jab', 'dark-pulse', 'night-slash', 'giga-impact', 'shadow-claw', 'defog', 'captivate', 'hone-claws', 'venoshock', 'acid-spray', 'foul-play', 'round', 'incinerate', 'snarl', 'belch', 'confide', 'venom-drench'], 'name': 'skuntank', 'stats': {'hp': 103, 'attack': 93, 'defense': 67, 'special-attack': 71, 'special-defense': 61, 'speed': 84}, 'types': ['poison', 'dark'], 'weight': 380, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 20, 'gender_rate': 4, 'capture_rate': 60, 'color': 'purple', 'shape': 'quadruped', 'habitat': None, 'generation': 'generation-iv', 'growth_rate': 'medium', 'egg_groups': ['ground'], 'names': {'ja-Hrkt': 'スカタンク', 'roomaji': 'Skutank', 'ko': '스컹탱크', 'zh-Hant': '坦克臭鼬', 'fr': 'Moufflair', 'de': 'Skuntank', 'es': 'Skuntank', 'it': 'Skuntank', 'en': 'Skuntank', 'ja': 'スカタンク', 'zh-Hans': '坦克臭鼬'}, 'genera': {'ja-Hrkt': 'スカンクポケモン', 'ko': '스컹크포켓몬', 'zh-Hant': '臭鼬寶可夢', 'fr': 'Pokémon Moufette', 'de': 'Stinktier', 'es': 'Pokémon Mofeta', 'it': 'Pokémon Moffetta', 'en': 'Skunk Pokémon', 'ja': 'スカンクポケモン', 'zh-Hans': '臭鼬宝可梦'}}
	public class SpecieSkuntank : PokemonSpecie
	{
#nullable enable
		private static SpecieSkuntank? _instance = null;
#nullable restore
        public static SpecieSkuntank Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieSkuntank();
                }
                return _instance;
            }
        }

		public SpecieSkuntank() : base(
			"Skuntank",
			103, // HPs
			93, 67, // Attack & Defense
			71, 61, // Special Attack & Defense
			84			
		) {}
	}


	//Skuntank Pokemon Class
	public class Skuntank : Pokemon
	{

		public Skuntank(string nickname, int level)
		: base(
				435,
				SpecieSkuntank.Instance, // Pokemon Specie
				nickname, level,
				Poison.Instance, Dark.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Skuntank() : base(
			435,
			SpecieSkuntank.Instance, // Pokemon Specie
			Poison.Instance, Dark.Instance			
		) {}
	}
}