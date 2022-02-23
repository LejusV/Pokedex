using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Larvesta Specie to store common natural stats of every {'abilities': ['flame-body', 'swarm'], 'base_experience': 72, 'height': 11, 'id': 636, 'moves': ['take-down', 'thrash', 'double-edge', 'ember', 'flamethrower', 'absorb', 'solar-beam', 'string-shot', 'toxic', 'psychic', 'double-team', 'harden', 'light-screen', 'fire-blast', 'amnesia', 'leech-life', 'rest', 'substitute', 'flame-wheel', 'snore', 'protect', 'foresight', 'giga-drain', 'endure', 'swagger', 'sleep-talk', 'return', 'frustration', 'safeguard', 'morning-sun', 'hidden-power', 'sunny-day', 'heat-wave', 'will-o-wisp', 'facade', 'secret-power', 'overheat', 'signal-beam', 'calm-mind', 'u-turn', 'magnet-rise', 'flare-blitz', 'bug-buzz', 'zen-headbutt', 'bug-bite', 'flame-charge', 'round', 'incinerate', 'acrobatics', 'struggle-bug', 'wild-charge', 'confide'], 'name': 'larvesta', 'stats': {'hp': 55, 'attack': 85, 'defense': 55, 'special-attack': 50, 'special-defense': 55, 'speed': 60}, 'types': ['bug', 'fire'], 'weight': 288, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 40, 'gender_rate': 4, 'capture_rate': 45, 'color': 'white', 'shape': 'armor', 'habitat': None, 'generation': 'generation-v', 'growth_rate': 'slow', 'egg_groups': ['bug'], 'names': {'ja-Hrkt': 'メラルバ', 'ko': '활화르바', 'zh-Hant': '燃燒蟲', 'fr': 'Pyronille', 'de': 'Ignivor', 'es': 'Larvesta', 'it': 'Larvesta', 'en': 'Larvesta', 'ja': 'メラルバ', 'zh-Hans': '燃烧虫'}, 'genera': {'ja-Hrkt': 'たいまつポケモン', 'ko': '횃불포켓몬', 'zh-Hant': '火炬寶可夢', 'fr': 'Pokémon Torche', 'de': 'Fackel', 'es': 'Pokémon Antorcha', 'it': 'Pokémon Torcia', 'en': 'Torch Pokémon', 'ja': 'たいまつポケモン', 'zh-Hans': '火炬宝可梦'}}
	public class SpecieLarvesta : PokemonSpecie
	{
#nullable enable
		private static SpecieLarvesta? _instance = null;
#nullable restore
        public static SpecieLarvesta Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieLarvesta();
                }
                return _instance;
            }
        }

		public SpecieLarvesta() : base(
			"Larvesta",
			55, // HPs
			85, 55, // Attack & Defense
			50, 55, // Special Attack & Defense
			60			
		) {}
	}


	//Larvesta Pokemon Class
	public class Larvesta : Pokemon
	{

		public Larvesta(string nickname, int level) : base(
			636,
			SpecieLarvesta.Instance, // Pokemon Specie
			nickname, level,
			Bug.Instance, Fire.Instance			
		) {}

		public Larvesta() : base(
			636,
			SpecieLarvesta.Instance, // Pokemon Specie
			Bug.Instance, Fire.Instance			
		) {}
	}
}