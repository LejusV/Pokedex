using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Golduck Specie to store common natural stats of every {'abilities': ['damp', 'cloud-nine', 'swift-swim'], 'base_experience': 175, 'height': 17, 'id': 55, 'moves': ['mega-punch', 'pay-day', 'ice-punch', 'scratch', 'mega-kick', 'headbutt', 'body-slam', 'take-down', 'double-edge', 'tail-whip', 'disable', 'water-gun', 'hydro-pump', 'surf', 'ice-beam', 'blizzard', 'bubble-beam', 'hyper-beam', 'submission', 'low-kick', 'counter', 'seismic-toss', 'strength', 'dig', 'toxic', 'confusion', 'psychic', 'rage', 'mimic', 'screech', 'double-team', 'light-screen', 'bide', 'waterfall', 'swift', 'skull-bash', 'amnesia', 'flash', 'fury-swipes', 'rest', 'substitute', 'snore', 'curse', 'protect', 'mud-slap', 'icy-wind', 'endure', 'swagger', 'fury-cutter', 'attract', 'sleep-talk', 'return', 'frustration', 'dynamic-punch', 'iron-tail', 'hidden-power', 'rain-dance', 'psych-up', 'rock-smash', 'whirlpool', 'hail', 'facade', 'focus-punch', 'role-play', 'brick-break', 'secret-power', 'dive', 'signal-beam', 'aerial-ace', 'water-sport', 'calm-mind', 'water-pulse', 'brine', 'natural-gift', 'fling', 'me-first', 'worry-seed', 'aqua-tail', 'focus-blast', 'giga-impact', 'shadow-claw', 'zen-headbutt', 'rock-climb', 'captivate', 'aqua-jet', 'hone-claws', 'wonder-room', 'psyshock', 'telekinesis', 'soak', 'low-sweep', 'round', 'scald', 'confide', 'power-up-punch'], 'name': 'golduck', 'stats': {'hp': 80, 'attack': 82, 'defense': 78, 'special-attack': 95, 'special-defense': 80, 'speed': 85}, 'types': ['water'], 'weight': 766, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 20, 'gender_rate': 4, 'capture_rate': 75, 'color': 'blue', 'shape': 'upright', 'habitat': 'waters-edge', 'generation': 'generation-i', 'growth_rate': 'medium', 'egg_groups': ['water1', 'ground'], 'names': {'ja-Hrkt': 'ゴルダック', 'roomaji': 'Golduck', 'ko': '골덕', 'zh-Hant': '哥達鴨', 'fr': 'Akwakwak', 'de': 'Entoron', 'es': 'Golduck', 'it': 'Golduck', 'en': 'Golduck', 'ja': 'ゴルダック', 'zh-Hans': '哥达鸭'}, 'genera': {'ja-Hrkt': 'あひるポケモン', 'ko': '오리포켓몬', 'zh-Hant': '鴨寶可夢', 'fr': 'Pokémon Canard', 'de': 'Ente', 'es': 'Pokémon Pato', 'it': 'Pokémon Papero', 'en': 'Duck Pokémon', 'ja': 'あひるポケモン', 'zh-Hans': '鸭宝可梦'}}
	public class SpecieGolduck : PokemonSpecie
	{
#nullable enable
		private static SpecieGolduck? _instance = null;
#nullable restore
        public static SpecieGolduck Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieGolduck();
                }
                return _instance;
            }
        }

		public SpecieGolduck() : base(
			"Golduck",
			80, // HPs
			82, 78, // Attack & Defense
			95, 80, // Special Attack & Defense
			85			
		) {}
	}


	//Golduck Pokemon Class
	public class Golduck : Pokemon
	{

		public Golduck(string nickname, int level) : base(
			55,
			SpecieGolduck.Instance, // Pokemon Specie
			nickname, level,
			Water.Instance			
		) {}

		public Golduck() : base(
			55,
			SpecieGolduck.Instance, // Pokemon Specie
			Water.Instance			
		) {}
	}
}