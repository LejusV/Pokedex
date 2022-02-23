using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Froslass Specie to store common natural stats of every {'abilities': ['snow-cloak', 'cursed-body'], 'base_experience': 168, 'height': 13, 'id': 478, 'moves': ['ice-punch', 'headbutt', 'leer', 'ice-beam', 'blizzard', 'hyper-beam', 'thunderbolt', 'thunder-wave', 'thunder', 'toxic', 'psychic', 'double-team', 'confuse-ray', 'light-screen', 'dream-eater', 'flash', 'rest', 'substitute', 'snore', 'spite', 'powder-snow', 'protect', 'mud-slap', 'destiny-bond', 'icy-wind', 'endure', 'rollout', 'swagger', 'attract', 'sleep-talk', 'return', 'frustration', 'safeguard', 'pain-split', 'hidden-power', 'rain-dance', 'psych-up', 'shadow-ball', 'hail', 'torment', 'will-o-wisp', 'facade', 'taunt', 'trick', 'snatch', 'secret-power', 'astonish', 'signal-beam', 'block', 'shock-wave', 'water-pulse', 'wake-up-slap', 'natural-gift', 'payback', 'embargo', 'fling', 'sucker-punch', 'giga-impact', 'avalanche', 'ice-shard', 'captivate', 'ominous-wind', 'telekinesis', 'round', 'frost-breath', 'draining-kiss', 'confide', 'aurora-veil'], 'name': 'froslass', 'stats': {'hp': 70, 'attack': 80, 'defense': 70, 'special-attack': 80, 'special-defense': 70, 'speed': 110}, 'types': ['ice', 'ghost'], 'weight': 266, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 20, 'gender_rate': 8, 'capture_rate': 75, 'color': 'white', 'shape': 'arms', 'habitat': None, 'generation': 'generation-iv', 'growth_rate': 'medium', 'egg_groups': ['fairy', 'mineral'], 'names': {'ja-Hrkt': 'ユキメノコ', 'roomaji': 'Yukimenoko', 'ko': '눈여아', 'zh-Hant': '雪妖女', 'fr': 'Momartik', 'de': 'Frosdedje', 'es': 'Froslass', 'it': 'Froslass', 'en': 'Froslass', 'ja': 'ユキメノコ', 'zh-Hans': '雪妖女'}, 'genera': {'ja-Hrkt': 'ゆきぐにポケモン', 'ko': '설국포켓몬', 'zh-Hant': '雪國寶可夢', 'fr': 'Pokémon Enneigement', 'de': 'Schneegebiet', 'es': 'Pokémon Tierra Fría', 'it': 'Pokémon Suolnevoso', 'en': 'Snow Land Pokémon', 'ja': 'ゆきぐにポケモン', 'zh-Hans': '雪国宝可梦'}}
	public class SpecieFroslass : PokemonSpecie
	{
#nullable enable
		private static SpecieFroslass? _instance = null;
#nullable restore
        public static SpecieFroslass Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieFroslass();
                }
                return _instance;
            }
        }

		public SpecieFroslass() : base(
			"Froslass",
			70, // HPs
			80, 70, // Attack & Defense
			80, 70, // Special Attack & Defense
			110			
		) {}
	}


	//Froslass Pokemon Class
	public class Froslass : Pokemon
	{

		public Froslass(string nickname, int level) : base(
			478,
			SpecieFroslass.Instance, // Pokemon Specie
			nickname, level,
			Ice.Instance, Ghost.Instance			
		) {}

		public Froslass() : base(
			478,
			SpecieFroslass.Instance, // Pokemon Specie
			Ice.Instance, Ghost.Instance			
		) {}
	}
}