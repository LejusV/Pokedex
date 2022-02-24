using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Spinarak Specie to store common natural stats of every {'abilities': ['swarm', 'insomnia', 'sniper'], 'base_experience': 50, 'height': 5, 'id': 167, 'moves': ['body-slam', 'double-edge', 'poison-sting', 'twineedle', 'pin-missile', 'sonic-boom', 'disable', 'psybeam', 'absorb', 'solar-beam', 'string-shot', 'dig', 'toxic', 'psychic', 'agility', 'night-shade', 'mimic', 'screech', 'double-team', 'constrict', 'leech-life', 'flash', 'fury-swipes', 'rest', 'substitute', 'thief', 'spider-web', 'snore', 'curse', 'protect', 'scary-face', 'sludge-bomb', 'giga-drain', 'endure', 'swagger', 'attract', 'sleep-talk', 'return', 'frustration', 'megahorn', 'baton-pass', 'pursuit', 'hidden-power', 'sunny-day', 'facade', 'secret-power', 'signal-beam', 'bounce', 'natural-gift', 'sucker-punch', 'toxic-spikes', 'poison-jab', 'night-slash', 'x-scissor', 'shadow-sneak', 'cross-poison', 'captivate', 'bug-bite', 'hone-claws', 'venoshock', 'rage-powder', 'foul-play', 'round', 'struggle-bug', 'electroweb', 'sticky-web', 'confide', 'infestation', 'toxic-thread', 'lunge'], 'name': 'spinarak', 'stats': {'hp': 40, 'attack': 60, 'defense': 40, 'special-attack': 40, 'special-defense': 40, 'speed': 30}, 'types': ['bug', 'poison'], 'weight': 85, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 15, 'gender_rate': 4, 'capture_rate': 255, 'color': 'green', 'shape': 'armor', 'habitat': 'forest', 'generation': 'generation-ii', 'growth_rate': 'fast', 'egg_groups': ['bug'], 'names': {'ja-Hrkt': 'イトマル', 'roomaji': 'Itomaru', 'ko': '페이검', 'zh-Hant': '圓絲蛛', 'fr': 'Mimigal', 'de': 'Webarak', 'es': 'Spinarak', 'it': 'Spinarak', 'en': 'Spinarak', 'ja': 'イトマル', 'zh-Hans': '圆丝蛛'}, 'genera': {'ja-Hrkt': 'いとはきポケモン', 'ko': '실뿜기포켓몬', 'zh-Hant': '吐絲寶可夢', 'fr': 'Pokémon Crache Fil', 'de': 'Fadenwurf', 'es': 'Pokémon Escupesoga', 'it': 'Pokémon Tela', 'en': 'String Spit Pokémon', 'ja': 'いとはきポケモン', 'zh-Hans': '吐丝宝可梦'}}
	public class SpecieSpinarak : PokemonSpecie
	{
#nullable enable
		private static SpecieSpinarak? _instance = null;
#nullable restore
        public static SpecieSpinarak Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieSpinarak();
                }
                return _instance;
            }
        }

		public SpecieSpinarak() : base(
			"Spinarak",
			40, // HPs
			60, 40, // Attack & Defense
			40, 40, // Special Attack & Defense
			30			
		) {}
	}


	//Spinarak Pokemon Class
	public class Spinarak : Pokemon
	{

		public Spinarak(string nickname, int level)
		: base(
				167,
				SpecieSpinarak.Instance, // Pokemon Specie
				nickname, level,
				Bug.Instance, Poison.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Spinarak() : base(
			167,
			SpecieSpinarak.Instance, // Pokemon Specie
			Bug.Instance, Poison.Instance			
		) {}
	}
}