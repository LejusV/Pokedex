using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Volbeat Specie to store common natural stats of every {'abilities': ['illuminate', 'swarm', 'prankster'], 'base_experience': 151, 'height': 7, 'id': 313, 'moves': ['mega-punch', 'ice-punch', 'thunder-punch', 'mega-kick', 'tackle', 'body-slam', 'double-edge', 'counter', 'seismic-toss', 'solar-beam', 'string-shot', 'thunderbolt', 'thunder-wave', 'thunder', 'toxic', 'quick-attack', 'mimic', 'double-team', 'confuse-ray', 'light-screen', 'metronome', 'swift', 'dizzy-punch', 'flash', 'rest', 'substitute', 'thief', 'snore', 'protect', 'mud-slap', 'giga-drain', 'endure', 'swagger', 'attract', 'sleep-talk', 'return', 'frustration', 'dynamic-punch', 'baton-pass', 'encore', 'moonlight', 'hidden-power', 'rain-dance', 'sunny-day', 'psych-up', 'shadow-ball', 'facade', 'focus-punch', 'helping-hand', 'trick', 'brick-break', 'secret-power', 'tail-glow', 'air-cutter', 'silver-wind', 'signal-beam', 'aerial-ace', 'shock-wave', 'water-pulse', 'roost', 'natural-gift', 'tailwind', 'u-turn', 'fling', 'bug-buzz', 'zen-headbutt', 'captivate', 'bug-bite', 'charge-beam', 'ominous-wind', 'round', 'acrobatics', 'struggle-bug', 'play-rough', 'confide', 'dazzling-gleam', 'infestation', 'power-up-punch', 'lunge'], 'name': 'volbeat', 'stats': {'hp': 65, 'attack': 73, 'defense': 75, 'special-attack': 47, 'special-defense': 85, 'speed': 85}, 'types': ['bug'], 'weight': 177, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 15, 'gender_rate': 0, 'capture_rate': 150, 'color': 'gray', 'shape': 'upright', 'habitat': 'forest', 'generation': 'generation-iii', 'growth_rate': 'slow-then-very-fast', 'egg_groups': ['bug', 'humanshape'], 'names': {'ja-Hrkt': 'バルビート', 'roomaji': 'Barubeat', 'ko': '볼비트', 'zh-Hant': '電螢蟲', 'fr': 'Muciole', 'de': 'Volbeat', 'es': 'Volbeat', 'it': 'Volbeat', 'en': 'Volbeat', 'ja': 'バルビート', 'zh-Hans': '电萤虫'}, 'genera': {'ja-Hrkt': 'ほたるポケモン', 'ko': '반딧불포켓몬', 'zh-Hant': '螢火蟲寶可夢', 'fr': 'Pokémon Luciole', 'de': 'Glühwürmchen', 'es': 'Pokémon Luciérnaga', 'it': 'Pokémon Lucciola', 'en': 'Firefly Pokémon', 'ja': 'ほたるポケモン', 'zh-Hans': '萤火虫宝可梦'}}
	public class SpecieVolbeat : PokemonSpecie
	{
#nullable enable
		private static SpecieVolbeat? _instance = null;
#nullable restore
        public static SpecieVolbeat Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieVolbeat();
                }
                return _instance;
            }
        }

		public SpecieVolbeat() : base(
			"Volbeat",
			65, // HPs
			73, 75, // Attack & Defense
			47, 85, // Special Attack & Defense
			85			
		) {}
	}


	//Volbeat Pokemon Class
	public class Volbeat : Pokemon
	{

		public Volbeat(string nickname, int level) : base(
			313,
			SpecieVolbeat.Instance, // Pokemon Specie
			nickname, level,
			Bug.Instance			
		) {}

		public Volbeat() : base(
			313,
			SpecieVolbeat.Instance, // Pokemon Specie
			Bug.Instance			
		) {}
	}
}