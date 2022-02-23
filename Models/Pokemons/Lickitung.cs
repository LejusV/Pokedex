using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Lickitung Specie to store common natural stats of every {'abilities': ['own-tempo', 'oblivious', 'cloud-nine'], 'base_experience': 77, 'height': 12, 'id': 108, 'moves': ['mega-punch', 'fire-punch', 'ice-punch', 'thunder-punch', 'swords-dance', 'cut', 'bind', 'slam', 'stomp', 'mega-kick', 'headbutt', 'body-slam', 'wrap', 'take-down', 'thrash', 'double-edge', 'supersonic', 'disable', 'flamethrower', 'water-gun', 'surf', 'ice-beam', 'blizzard', 'bubble-beam', 'hyper-beam', 'submission', 'counter', 'seismic-toss', 'strength', 'solar-beam', 'thunderbolt', 'thunder', 'earthquake', 'fissure', 'dig', 'toxic', 'rage', 'mimic', 'screech', 'double-team', 'defense-curl', 'bide', 'lick', 'fire-blast', 'skull-bash', 'amnesia', 'dream-eater', 'rest', 'rock-slide', 'substitute', 'thief', 'nightmare', 'snore', 'curse', 'protect', 'belly-drum', 'mud-slap', 'icy-wind', 'sandstorm', 'endure', 'rollout', 'swagger', 'attract', 'sleep-talk', 'return', 'frustration', 'magnitude', 'dynamic-punch', 'iron-tail', 'hidden-power', 'rain-dance', 'sunny-day', 'psych-up', 'shadow-ball', 'rock-smash', 'whirlpool', 'facade', 'focus-punch', 'smelling-salts', 'brick-break', 'knock-off', 'refresh', 'secret-power', 'rock-tomb', 'muddy-water', 'shock-wave', 'water-pulse', 'hammer-arm', 'natural-gift', 'fling', 'wring-out', 'me-first', 'aqua-tail', 'giga-impact', 'zen-headbutt', 'rock-climb', 'power-whip', 'captivate', 'round', 'chip-away', 'incinerate', 'retaliate', 'bulldoze', 'dragon-tail', 'work-up', 'belch', 'confide', 'power-up-punch', 'brutal-swing'], 'name': 'lickitung', 'stats': {'hp': 90, 'attack': 55, 'defense': 75, 'special-attack': 60, 'special-defense': 75, 'speed': 30}, 'types': ['normal'], 'weight': 655, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 20, 'gender_rate': 4, 'capture_rate': 45, 'color': 'pink', 'shape': 'upright', 'habitat': 'grassland', 'generation': 'generation-i', 'growth_rate': 'medium', 'egg_groups': ['monster'], 'names': {'ja-Hrkt': 'ベロリンガ', 'roomaji': 'Beroringa', 'ko': '내루미', 'zh-Hant': '大舌頭', 'fr': 'Excelangue', 'de': 'Schlurp', 'es': 'Lickitung', 'it': 'Lickitung', 'en': 'Lickitung', 'ja': 'ベロリンガ', 'zh-Hans': '大舌头'}, 'genera': {'ja-Hrkt': 'なめまわしポケモン', 'ko': '핥기포켓몬', 'zh-Hant': '舔舔寶可夢', 'fr': 'Pokémon Lécheur', 'de': 'Schlecker', 'es': 'Pokémon Lametazo', 'it': 'Pokémon Linguaccia', 'en': 'Licking Pokémon', 'ja': 'なめまわしポケモン', 'zh-Hans': '舔舔宝可梦'}}
	public class SpecieLickitung : PokemonSpecie
	{
#nullable enable
		private static SpecieLickitung? _instance = null;
#nullable restore
        public static SpecieLickitung Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieLickitung();
                }
                return _instance;
            }
        }

		public SpecieLickitung() : base(
			"Lickitung",
			90, // HPs
			55, 75, // Attack & Defense
			60, 75, // Special Attack & Defense
			30			
		) {}
	}


	//Lickitung Pokemon Class
	public class Lickitung : Pokemon
	{

		public Lickitung(string nickname, int level) : base(
			108,
			SpecieLickitung.Instance, // Pokemon Specie
			nickname, level,
			Normal.Instance			
		) {}

		public Lickitung() : base(
			108,
			SpecieLickitung.Instance, // Pokemon Specie
			Normal.Instance			
		) {}
	}
}