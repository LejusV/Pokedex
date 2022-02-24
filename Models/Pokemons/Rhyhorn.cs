using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Rhyhorn Specie to store common natural stats of every {'abilities': ['lightning-rod', 'rock-head', 'reckless'], 'base_experience': 69, 'height': 10, 'id': 111, 'moves': ['swords-dance', 'stomp', 'headbutt', 'horn-attack', 'fury-attack', 'horn-drill', 'body-slam', 'take-down', 'thrash', 'double-edge', 'tail-whip', 'leer', 'roar', 'flamethrower', 'ice-beam', 'blizzard', 'counter', 'strength', 'thunderbolt', 'thunder', 'earthquake', 'fissure', 'dig', 'toxic', 'rage', 'mimic', 'double-team', 'bide', 'fire-blast', 'skull-bash', 'rest', 'rock-slide', 'substitute', 'thief', 'snore', 'curse', 'reversal', 'spite', 'protect', 'scary-face', 'mud-slap', 'zap-cannon', 'icy-wind', 'sandstorm', 'endure', 'rollout', 'swagger', 'attract', 'sleep-talk', 'return', 'frustration', 'magnitude', 'megahorn', 'pursuit', 'iron-tail', 'hidden-power', 'rain-dance', 'sunny-day', 'crunch', 'ancient-power', 'rock-smash', 'uproar', 'facade', 'superpower', 'endeavor', 'secret-power', 'crush-claw', 'rock-tomb', 'rock-blast', 'shock-wave', 'natural-gift', 'metal-burst', 'payback', 'rock-polish', 'poison-jab', 'aqua-tail', 'dragon-pulse', 'dragon-rush', 'earth-power', 'thunder-fang', 'ice-fang', 'fire-fang', 'rock-climb', 'stone-edge', 'captivate', 'stealth-rock', 'guard-split', 'smack-down', 'round', 'chip-away', 'incinerate', 'bulldoze', 'drill-run', 'rototiller', 'confide', 'smart-strike'], 'name': 'rhyhorn', 'stats': {'hp': 80, 'attack': 85, 'defense': 95, 'special-attack': 30, 'special-defense': 30, 'speed': 25}, 'types': ['ground', 'rock'], 'weight': 1150, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 20, 'gender_rate': 4, 'capture_rate': 120, 'color': 'gray', 'shape': 'quadruped', 'habitat': 'rough-terrain', 'generation': 'generation-i', 'growth_rate': 'slow', 'egg_groups': ['monster', 'ground'], 'names': {'ja-Hrkt': 'サイホーン', 'roomaji': 'Sihorn', 'ko': '뿔카노', 'zh-Hant': '獨角犀牛', 'fr': 'Rhinocorne', 'de': 'Rihorn', 'es': 'Rhyhorn', 'it': 'Rhyhorn', 'en': 'Rhyhorn', 'ja': 'サイホーン', 'zh-Hans': '独角犀牛'}, 'genera': {'ja-Hrkt': 'とげとげポケモン', 'ko': '뿔포켓몬', 'zh-Hant': '尖尖寶可夢', 'fr': 'Pokémon Piquant', 'de': 'Stachler', 'es': 'Pokémon Clavos', 'it': 'Pokémon Punzoni', 'en': 'Spikes Pokémon', 'ja': 'とげとげポケモン', 'zh-Hans': '尖尖宝可梦'}}
	public class SpecieRhyhorn : PokemonSpecie
	{
#nullable enable
		private static SpecieRhyhorn? _instance = null;
#nullable restore
        public static SpecieRhyhorn Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieRhyhorn();
                }
                return _instance;
            }
        }

		public SpecieRhyhorn() : base(
			"Rhyhorn",
			80, // HPs
			85, 95, // Attack & Defense
			30, 30, // Special Attack & Defense
			25			
		) {}
	}


	//Rhyhorn Pokemon Class
	public class Rhyhorn : Pokemon
	{

		public Rhyhorn(string nickname, int level)
		: base(
				111,
				SpecieRhyhorn.Instance, // Pokemon Specie
				nickname, level,
				Ground.Instance, Rock.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Rhyhorn(int level)
		: base(
				111,
				SpecieRhyhorn.Instance, // Pokemon Specie
				"Rhyhorn", level,
				Ground.Instance, Rock.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Rhyhorn() : base(
			111,
			SpecieRhyhorn.Instance, // Pokemon Specie
			Ground.Instance, Rock.Instance			
		) {}
	}
}