using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Delibird Specie to store common natural stats of every {'abilities': ['vital-spirit', 'hustle', 'insomnia'], 'base_experience': 116, 'height': 9, 'id': 225, 'moves': ['mega-punch', 'ice-punch', 'fly', 'mega-kick', 'headbutt', 'body-slam', 'double-edge', 'ice-beam', 'blizzard', 'aurora-beam', 'drill-peck', 'counter', 'seismic-toss', 'toxic', 'quick-attack', 'mimic', 'double-team', 'swift', 'sky-attack', 'splash', 'rest', 'substitute', 'thief', 'snore', 'curse', 'protect', 'mud-slap', 'spikes', 'destiny-bond', 'icy-wind', 'detect', 'endure', 'rollout', 'swagger', 'attract', 'sleep-talk', 'return', 'present', 'frustration', 'rapid-spin', 'hidden-power', 'rain-dance', 'future-sight', 'fake-out', 'hail', 'facade', 'focus-punch', 'recycle', 'brick-break', 'secret-power', 'ice-ball', 'signal-beam', 'aerial-ace', 'bounce', 'water-pulse', 'natural-gift', 'pluck', 'fling', 'seed-bomb', 'avalanche', 'ice-shard', 'defog', 'gunk-shot', 'captivate', 'round', 'bestow', 'frost-breath', 'freeze-dry', 'confide', 'power-up-punch', 'brutal-swing', 'aurora-veil'], 'name': 'delibird', 'stats': {'hp': 45, 'attack': 55, 'defense': 45, 'special-attack': 65, 'special-defense': 45, 'speed': 75}, 'types': ['ice', 'flying'], 'weight': 160, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 20, 'gender_rate': 4, 'capture_rate': 45, 'color': 'red', 'shape': 'wings', 'habitat': 'mountain', 'generation': 'generation-ii', 'growth_rate': 'fast', 'egg_groups': ['water1', 'ground'], 'names': {'ja-Hrkt': 'デリバード', 'roomaji': 'Delibird', 'ko': '딜리버드', 'zh-Hant': '信使鳥', 'fr': 'Cadoizo', 'de': 'Botogel', 'es': 'Delibird', 'it': 'Delibird', 'en': 'Delibird', 'ja': 'デリバード', 'zh-Hans': '信使鸟'}, 'genera': {'ja-Hrkt': 'はこびやポケモン', 'ko': '배달포켓몬', 'zh-Hant': '搬運寶可夢', 'fr': 'Pokémon Livraison', 'de': 'Lieferant', 'es': 'Pokémon Reparto', 'it': 'Pokémon Consegna', 'en': 'Delivery Pokémon', 'ja': 'はこびやポケモン', 'zh-Hans': '搬运宝可梦'}}
	public class SpecieDelibird : PokemonSpecie
	{
#nullable enable
		private static SpecieDelibird? _instance = null;
#nullable restore
        public static SpecieDelibird Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieDelibird();
                }
                return _instance;
            }
        }

		public SpecieDelibird() : base(
			"Delibird",
			45, // HPs
			55, 45, // Attack & Defense
			65, 45, // Special Attack & Defense
			75			
		) {}
	}


	//Delibird Pokemon Class
	public class Delibird : Pokemon
	{

		public Delibird(string nickname, int level)
		: base(
				225,
				SpecieDelibird.Instance, // Pokemon Specie
				nickname, level,
				Ice.Instance, Flying.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Delibird(int level)
		: base(
				225,
				SpecieDelibird.Instance, // Pokemon Specie
				"Delibird", level,
				Ice.Instance, Flying.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Delibird() : base(
			225,
			SpecieDelibird.Instance, // Pokemon Specie
			Ice.Instance, Flying.Instance			
		) {}
	}
}