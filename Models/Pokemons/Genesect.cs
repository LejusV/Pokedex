using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Genesect Specie to store common natural stats of every {'abilities': ['download'], 'base_experience': 270, 'height': 15, 'id': 649, 'moves': ['fly', 'flamethrower', 'ice-beam', 'blizzard', 'hyper-beam', 'solar-beam', 'thunderbolt', 'thunder-wave', 'thunder', 'toxic', 'psychic', 'quick-attack', 'screech', 'double-team', 'light-screen', 'reflect', 'self-destruct', 'flash', 'explosion', 'rest', 'tri-attack', 'slash', 'substitute', 'snore', 'protect', 'zap-cannon', 'lock-on', 'giga-drain', 'swagger', 'fury-cutter', 'sleep-talk', 'return', 'frustration', 'metal-claw', 'hidden-power', 'facade', 'magic-coat', 'recycle', 'secret-power', 'metal-sound', 'signal-beam', 'aerial-ace', 'iron-defense', 'shock-wave', 'gravity', 'u-turn', 'last-resort', 'magnet-rise', 'rock-polish', 'dark-pulse', 'x-scissor', 'bug-buzz', 'energy-ball', 'giga-impact', 'shadow-claw', 'zen-headbutt', 'flash-cannon', 'gunk-shot', 'iron-head', 'magnet-bomb', 'bug-bite', 'charge-beam', 'hone-claws', 'flame-charge', 'simple-beam', 'round', 'struggle-bug', 'electroweb', 'techno-blast', 'fell-stinger', 'confide', 'infestation'], 'name': 'genesect', 'stats': {'hp': 71, 'attack': 120, 'defense': 95, 'special-attack': 120, 'special-defense': 95, 'speed': 99}, 'types': ['bug', 'steel'], 'weight': 825, 'is_baby': False, 'is_legendary': False, 'is_mythical': True, 'hatch_counter': 120, 'gender_rate': -1, 'capture_rate': 3, 'color': 'purple', 'shape': 'humanoid', 'habitat': None, 'generation': 'generation-v', 'growth_rate': 'slow', 'egg_groups': ['no-eggs'], 'names': {'ja-Hrkt': 'ゲノセクト', 'ko': '게노세크트', 'zh-Hant': '蓋諾賽克特', 'fr': 'Genesect', 'de': 'Genesect', 'es': 'Genesect', 'it': 'Genesect', 'en': 'Genesect', 'ja': 'ゲノセクト', 'zh-Hans': '盖诺赛克特'}, 'genera': {'ja-Hrkt': 'こせいだいポケモン', 'ko': '고생대포켓몬', 'zh-Hant': '古生代寶可夢', 'fr': 'Pokémon Paléozoïque', 'de': 'Paläozoikum', 'es': 'Pokémon Paleozoico', 'it': 'Pokémon Paleozoico', 'en': 'Paleozoic Pokémon', 'ja': 'こせいだいポケモン', 'zh-Hans': '古生代宝可梦'}}
	public class SpecieGenesect : PokemonSpecie
	{
#nullable enable
		private static SpecieGenesect? _instance = null;
#nullable restore
        public static SpecieGenesect Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieGenesect();
                }
                return _instance;
            }
        }

		public SpecieGenesect() : base(
			"Genesect",
			71, // HPs
			120, 95, // Attack & Defense
			120, 95, // Special Attack & Defense
			99			
		) {}
	}


	//Genesect Pokemon Class
	public class Genesect : Pokemon
	{

		public Genesect(string nickname, int level)
		: base(
				649,
				SpecieGenesect.Instance, // Pokemon Specie
				nickname, level,
				Bug.Instance, Steel.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Genesect() : base(
			649,
			SpecieGenesect.Instance, // Pokemon Specie
			Bug.Instance, Steel.Instance			
		) {}
	}
}