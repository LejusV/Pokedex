using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Quagsire Specie to store common natural stats of every {'abilities': ['damp', 'water-absorb', 'unaware'], 'base_experience': 151, 'height': 14, 'id': 195, 'moves': ['mega-punch', 'ice-punch', 'slam', 'mega-kick', 'headbutt', 'body-slam', 'double-edge', 'tail-whip', 'mist', 'water-gun', 'surf', 'ice-beam', 'blizzard', 'hyper-beam', 'counter', 'seismic-toss', 'strength', 'earthquake', 'dig', 'toxic', 'mimic', 'double-team', 'defense-curl', 'haze', 'waterfall', 'amnesia', 'flash', 'rest', 'rock-slide', 'substitute', 'thief', 'snore', 'curse', 'protect', 'sludge-bomb', 'mud-slap', 'icy-wind', 'sandstorm', 'endure', 'rollout', 'swagger', 'attract', 'sleep-talk', 'return', 'frustration', 'safeguard', 'dynamic-punch', 'iron-tail', 'hidden-power', 'rain-dance', 'ancient-power', 'rock-smash', 'whirlpool', 'hail', 'facade', 'focus-punch', 'brick-break', 'yawn', 'secret-power', 'dive', 'mud-sport', 'rock-tomb', 'muddy-water', 'mud-shot', 'water-pulse', 'natural-gift', 'fling', 'aqua-tail', 'focus-blast', 'earth-power', 'giga-impact', 'mud-bomb', 'stone-edge', 'captivate', 'sludge-wave', 'after-you', 'round', 'scald', 'bulldoze', 'confide', 'infestation', 'power-up-punch'], 'name': 'quagsire', 'stats': {'hp': 95, 'attack': 85, 'defense': 85, 'special-attack': 65, 'special-defense': 65, 'speed': 35}, 'types': ['water', 'ground'], 'weight': 750, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 20, 'gender_rate': 4, 'capture_rate': 90, 'color': 'blue', 'shape': 'upright', 'habitat': 'waters-edge', 'generation': 'generation-ii', 'growth_rate': 'medium', 'egg_groups': ['water1', 'ground'], 'names': {'ja-Hrkt': 'ヌオー', 'roomaji': 'Nuoh', 'ko': '누오', 'zh-Hant': '沼王', 'fr': 'Maraiste', 'de': 'Morlord', 'es': 'Quagsire', 'it': 'Quagsire', 'en': 'Quagsire', 'ja': 'ヌオー', 'zh-Hans': '沼王'}, 'genera': {'ja-Hrkt': 'みずうおポケモン', 'ko': '수어포켓몬', 'zh-Hant': '水魚寶可夢', 'fr': 'Pokémon Poisson', 'de': 'Fisch', 'es': 'Pokémon Pez Agua', 'it': 'Pokémon Acquapesce', 'en': 'Water Fish Pokémon', 'ja': 'みずうおポケモン', 'zh-Hans': '水鱼宝可梦'}}
	public class SpecieQuagsire : PokemonSpecie
	{
#nullable enable
		private static SpecieQuagsire? _instance = null;
#nullable restore
        public static SpecieQuagsire Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieQuagsire();
                }
                return _instance;
            }
        }

		public SpecieQuagsire() : base(
			"Quagsire",
			95, // HPs
			85, 85, // Attack & Defense
			65, 65, // Special Attack & Defense
			35			
		) {}
	}


	//Quagsire Pokemon Class
	public class Quagsire : Pokemon
	{

		public Quagsire(string nickname, int level) : base(
			195,
			SpecieQuagsire.Instance, // Pokemon Specie
			nickname, level,
			Water.Instance, Ground.Instance			
		) {}

		public Quagsire() : base(
			195,
			SpecieQuagsire.Instance, // Pokemon Specie
			Water.Instance, Ground.Instance			
		) {}
	}
}