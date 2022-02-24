using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Lickilicky Specie to store common natural stats of every {'abilities': ['own-tempo', 'oblivious', 'cloud-nine'], 'base_experience': 180, 'height': 17, 'id': 463, 'moves': ['fire-punch', 'ice-punch', 'thunder-punch', 'swords-dance', 'cut', 'bind', 'slam', 'stomp', 'headbutt', 'wrap', 'supersonic', 'disable', 'flamethrower', 'surf', 'ice-beam', 'blizzard', 'hyper-beam', 'strength', 'solar-beam', 'thunderbolt', 'thunder', 'earthquake', 'dig', 'toxic', 'screech', 'double-team', 'defense-curl', 'lick', 'fire-blast', 'dream-eater', 'explosion', 'rest', 'rock-slide', 'substitute', 'thief', 'snore', 'protect', 'mud-slap', 'icy-wind', 'sandstorm', 'endure', 'rollout', 'swagger', 'attract', 'sleep-talk', 'return', 'frustration', 'iron-tail', 'hidden-power', 'rain-dance', 'sunny-day', 'psych-up', 'shadow-ball', 'rock-smash', 'whirlpool', 'facade', 'focus-punch', 'brick-break', 'knock-off', 'refresh', 'secret-power', 'rock-tomb', 'block', 'shock-wave', 'water-pulse', 'gyro-ball', 'natural-gift', 'fling', 'wring-out', 'me-first', 'aqua-tail', 'focus-blast', 'giga-impact', 'zen-headbutt', 'rock-climb', 'power-whip', 'captivate', 'round', 'chip-away', 'incinerate', 'retaliate', 'bulldoze', 'dragon-tail', 'work-up', 'confide', 'power-up-punch', 'brutal-swing'], 'name': 'lickilicky', 'stats': {'hp': 110, 'attack': 85, 'defense': 95, 'special-attack': 80, 'special-defense': 95, 'speed': 50}, 'types': ['normal'], 'weight': 1400, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 20, 'gender_rate': 4, 'capture_rate': 30, 'color': 'pink', 'shape': 'humanoid', 'habitat': None, 'generation': 'generation-iv', 'growth_rate': 'medium', 'egg_groups': ['monster'], 'names': {'ja-Hrkt': 'ベロベルト', 'roomaji': 'Beroberto', 'ko': '내룸벨트', 'zh-Hant': '大舌舔', 'fr': 'Coudlangue', 'de': 'Schlurplek', 'es': 'Lickilicky', 'it': 'Lickilicky', 'en': 'Lickilicky', 'ja': 'ベロベルト', 'zh-Hans': '大舌舔'}, 'genera': {'ja-Hrkt': 'なめまわしポケモン', 'ko': '핥기포켓몬', 'zh-Hant': '舔舔寶可夢', 'fr': 'Pokémon Lécheur', 'de': 'Schlecker', 'es': 'Pokémon Lametazo', 'it': 'Pokémon Linguaccia', 'en': 'Licking Pokémon', 'ja': 'なめまわしポケモン', 'zh-Hans': '舔舔宝可梦'}}
	public class SpecieLickilicky : PokemonSpecie
	{
#nullable enable
		private static SpecieLickilicky? _instance = null;
#nullable restore
        public static SpecieLickilicky Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieLickilicky();
                }
                return _instance;
            }
        }

		public SpecieLickilicky() : base(
			"Lickilicky",
			110, // HPs
			85, 95, // Attack & Defense
			80, 95, // Special Attack & Defense
			50			
		) {}
	}


	//Lickilicky Pokemon Class
	public class Lickilicky : Pokemon
	{

		public Lickilicky(string nickname, int level)
		: base(
				463,
				SpecieLickilicky.Instance, // Pokemon Specie
				nickname, level,
				Normal.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Lickilicky() : base(
			463,
			SpecieLickilicky.Instance, // Pokemon Specie
			Normal.Instance			
		) {}
	}
}