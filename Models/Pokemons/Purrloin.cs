using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Purrloin Specie to store common natural stats of every {'abilities': ['limber', 'unburden', 'prankster'], 'base_experience': 56, 'height': 4, 'id': 509, 'moves': ['pay-day', 'scratch', 'cut', 'sand-attack', 'growl', 'thunder-wave', 'toxic', 'double-team', 'dream-eater', 'fury-swipes', 'rest', 'slash', 'substitute', 'thief', 'snore', 'spite', 'protect', 'feint-attack', 'charm', 'swagger', 'attract', 'sleep-talk', 'return', 'frustration', 'encore', 'pursuit', 'iron-tail', 'hidden-power', 'rain-dance', 'sunny-day', 'psych-up', 'shadow-ball', 'fake-out', 'torment', 'facade', 'taunt', 'trick', 'role-play', 'assist', 'yawn', 'knock-off', 'snatch', 'secret-power', 'hyper-voice', 'fake-tears', 'aerial-ace', 'covet', 'u-turn', 'payback', 'assurance', 'embargo', 'copycat', 'sucker-punch', 'dark-pulse', 'night-slash', 'seed-bomb', 'nasty-plot', 'shadow-claw', 'gunk-shot', 'captivate', 'grass-knot', 'hone-claws', 'foul-play', 'round', 'echoed-voice', 'snarl', 'play-rough', 'confide'], 'name': 'purrloin', 'stats': {'hp': 41, 'attack': 50, 'defense': 37, 'special-attack': 50, 'special-defense': 37, 'speed': 66}, 'types': ['dark'], 'weight': 101, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 20, 'gender_rate': 4, 'capture_rate': 255, 'color': 'purple', 'shape': 'quadruped', 'habitat': None, 'generation': 'generation-v', 'growth_rate': 'medium', 'egg_groups': ['ground'], 'names': {'ja-Hrkt': 'チョロネコ', 'ko': '쌔비냥', 'zh-Hant': '扒手貓', 'fr': 'Chacripan', 'de': 'Felilou', 'es': 'Purrloin', 'it': 'Purrloin', 'en': 'Purrloin', 'ja': 'チョロネコ', 'zh-Hans': '扒手猫'}, 'genera': {'ja-Hrkt': 'しょうわるポケモン', 'ko': '성악포켓몬', 'zh-Hant': '壞心眼寶可夢', 'fr': 'Pokémon Scélérat', 'de': 'Schelm', 'es': 'Pokémon Malicioso', 'it': 'Pokémon Furbizia', 'en': 'Devious Pokémon', 'ja': 'しょうわるポケモン', 'zh-Hans': '坏心眼宝可梦'}}
	public class SpeciePurrloin : PokemonSpecie
	{
#nullable enable
		private static SpeciePurrloin? _instance = null;
#nullable restore
        public static SpeciePurrloin Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciePurrloin();
                }
                return _instance;
            }
        }

		public SpeciePurrloin() : base(
			"Purrloin",
			41, // HPs
			50, 37, // Attack & Defense
			50, 37, // Special Attack & Defense
			66			
		) {}
	}


	//Purrloin Pokemon Class
	public class Purrloin : Pokemon
	{

		public Purrloin(string nickname, int level) : base(
			509,
			SpeciePurrloin.Instance, // Pokemon Specie
			nickname, level,
			Dark.Instance			
		) {}

		public Purrloin() : base(
			509,
			SpeciePurrloin.Instance, // Pokemon Specie
			Dark.Instance			
		) {}
	}
}