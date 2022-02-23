using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Buzzwole Specie to store common natural stats of every {'abilities': ['beast-boost'], 'base_experience': 257, 'height': 24, 'id': 794, 'moves': ['comet-punch', 'mega-punch', 'ice-punch', 'thunder-punch', 'counter', 'earthquake', 'toxic', 'double-team', 'harden', 'focus-energy', 'leech-life', 'rest', 'rock-slide', 'substitute', 'reversal', 'protect', 'endure', 'false-swipe', 'swagger', 'sleep-talk', 'return', 'frustration', 'dynamic-punch', 'vital-throw', 'hidden-power', 'facade', 'focus-punch', 'taunt', 'superpower', 'brick-break', 'rock-tomb', 'bulk-up', 'roost', 'hammer-arm', 'gyro-ball', 'payback', 'fling', 'poison-jab', 'giga-impact', 'stone-edge', 'smack-down', 'low-sweep', 'round', 'bulldoze', 'work-up', 'fell-stinger', 'confide', 'power-up-punch', 'lunge'], 'name': 'buzzwole', 'stats': {'hp': 107, 'attack': 139, 'defense': 139, 'special-attack': 53, 'special-defense': 53, 'speed': 79}, 'types': ['bug', 'fighting'], 'weight': 3336, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 120, 'gender_rate': -1, 'capture_rate': 45, 'color': 'red', 'shape': 'tentacles', 'habitat': None, 'generation': 'generation-vii', 'growth_rate': 'slow', 'egg_groups': ['no-eggs'], 'names': {'ja-Hrkt': 'マッシブーン', 'ko': '매시붕', 'zh-Hant': '爆肌蚊', 'fr': 'Mouscoto', 'de': 'Masskito', 'es': 'Buzzwole', 'it': 'Buzzwole', 'en': 'Buzzwole', 'ja': 'マッシブーン', 'zh-Hans': '爆肌蚊'}, 'genera': {'ja-Hrkt': 'ぼうちょうポケモン', 'ko': '팽창포켓몬', 'zh-Hant': '膨脹寶可夢', 'fr': 'Pokémon Enflé', 'de': 'Ausdehnung', 'es': 'Pokémon Hinchado', 'it': 'Pokémon Gonfiacorpo', 'en': 'Swollen Pokémon', 'ja': 'ぼうちょうポケモン', 'zh-Hans': '膨胀宝可梦'}}
	public class SpecieBuzzwole : PokemonSpecie
	{
#nullable enable
		private static SpecieBuzzwole? _instance = null;
#nullable restore
        public static SpecieBuzzwole Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieBuzzwole();
                }
                return _instance;
            }
        }

		public SpecieBuzzwole() : base(
			"Buzzwole",
			107, // HPs
			139, 139, // Attack & Defense
			53, 53, // Special Attack & Defense
			79			
		) {}
	}


	//Buzzwole Pokemon Class
	public class Buzzwole : Pokemon
	{

		public Buzzwole(string nickname, int level) : base(
			794,
			SpecieBuzzwole.Instance, // Pokemon Specie
			nickname, level,
			Bug.Instance, Fighting.Instance			
		) {}

		public Buzzwole() : base(
			794,
			SpecieBuzzwole.Instance, // Pokemon Specie
			Bug.Instance, Fighting.Instance			
		) {}
	}
}