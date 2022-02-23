using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Cacnea Specie to store common natural stats of every {'abilities': ['sand-veil', 'water-absorb'], 'base_experience': 67, 'height': 4, 'id': 331, 'moves': ['mega-punch', 'thunder-punch', 'swords-dance', 'cut', 'sand-attack', 'headbutt', 'body-slam', 'double-edge', 'poison-sting', 'pin-missile', 'leer', 'disable', 'acid', 'low-kick', 'counter', 'seismic-toss', 'absorb', 'leech-seed', 'growth', 'solar-beam', 'toxic', 'mimic', 'double-team', 'flash', 'rest', 'substitute', 'snore', 'cotton-spore', 'spite', 'protect', 'feint-attack', 'mud-slap', 'spikes', 'destiny-bond', 'sandstorm', 'giga-drain', 'endure', 'swagger', 'fury-cutter', 'attract', 'sleep-talk', 'return', 'frustration', 'dynamic-punch', 'synthesis', 'hidden-power', 'sunny-day', 'facade', 'focus-punch', 'smelling-salts', 'nature-power', 'role-play', 'ingrain', 'brick-break', 'secret-power', 'teeter-dance', 'needle-arm', 'grass-whistle', 'bullet-seed', 'block', 'magical-leaf', 'natural-gift', 'payback', 'fling', 'worry-seed', 'sucker-punch', 'poison-jab', 'dark-pulse', 'seed-bomb', 'drain-punch', 'energy-ball', 'switcheroo', 'nasty-plot', 'captivate', 'grass-knot', 'venoshock', 'round', 'belch', 'rototiller', 'fell-stinger', 'confide', 'power-up-punch'], 'name': 'cacnea', 'stats': {'hp': 50, 'attack': 85, 'defense': 40, 'special-attack': 85, 'special-defense': 40, 'speed': 35}, 'types': ['grass'], 'weight': 513, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 20, 'gender_rate': 4, 'capture_rate': 190, 'color': 'green', 'shape': 'humanoid', 'habitat': 'rough-terrain', 'generation': 'generation-iii', 'growth_rate': 'medium-slow', 'egg_groups': ['plant', 'humanshape'], 'names': {'ja-Hrkt': 'サボネア', 'roomaji': 'Sabonea', 'ko': '선인왕', 'zh-Hant': '刺球仙人掌', 'fr': 'Cacnea', 'de': 'Tuska', 'es': 'Cacnea', 'it': 'Cacnea', 'en': 'Cacnea', 'ja': 'サボネア', 'zh-Hans': '刺球仙人掌'}, 'genera': {'ja-Hrkt': 'サボテンポケモン', 'ko': '선인장포켓몬', 'zh-Hant': '仙人掌寶可夢', 'fr': 'Pokémon Cactus', 'de': 'Kaktus', 'es': 'Pokémon Cactus', 'it': 'Pokémon Cactus', 'en': 'Cactus Pokémon', 'ja': 'サボテンポケモン', 'zh-Hans': '仙人掌宝可梦'}}
	public class SpecieCacnea : PokemonSpecie
	{
#nullable enable
		private static SpecieCacnea? _instance = null;
#nullable restore
        public static SpecieCacnea Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieCacnea();
                }
                return _instance;
            }
        }

		public SpecieCacnea() : base(
			"Cacnea",
			50, // HPs
			85, 40, // Attack & Defense
			85, 40, // Special Attack & Defense
			35			
		) {}
	}


	//Cacnea Pokemon Class
	public class Cacnea : Pokemon
	{

		public Cacnea(string nickname, int level) : base(
			331,
			SpecieCacnea.Instance, // Pokemon Specie
			nickname, level,
			Grass.Instance			
		) {}

		public Cacnea() : base(
			331,
			SpecieCacnea.Instance, // Pokemon Specie
			Grass.Instance			
		) {}
	}
}