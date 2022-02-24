using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Granbull Specie to store common natural stats of every {'abilities': ['intimidate', 'quick-feet', 'rattled'], 'base_experience': 158, 'height': 14, 'id': 210, 'moves': ['mega-punch', 'fire-punch', 'ice-punch', 'thunder-punch', 'mega-kick', 'headbutt', 'tackle', 'body-slam', 'take-down', 'double-edge', 'tail-whip', 'bite', 'roar', 'flamethrower', 'hyper-beam', 'low-kick', 'counter', 'seismic-toss', 'strength', 'solar-beam', 'thunderbolt', 'thunder-wave', 'thunder', 'earthquake', 'dig', 'toxic', 'rage', 'mimic', 'double-team', 'defense-curl', 'reflect', 'metronome', 'lick', 'fire-blast', 'rest', 'rock-slide', 'super-fang', 'substitute', 'thief', 'snore', 'curse', 'protect', 'scary-face', 'sludge-bomb', 'mud-slap', 'zap-cannon', 'detect', 'outrage', 'endure', 'charm', 'swagger', 'attract', 'sleep-talk', 'heal-bell', 'return', 'frustration', 'dynamic-punch', 'iron-tail', 'hidden-power', 'rain-dance', 'sunny-day', 'crunch', 'shadow-ball', 'rock-smash', 'torment', 'facade', 'focus-punch', 'taunt', 'superpower', 'brick-break', 'secret-power', 'hyper-voice', 'overheat', 'rock-tomb', 'bulk-up', 'covet', 'shock-wave', 'water-pulse', 'natural-gift', 'payback', 'fling', 'last-resort', 'focus-blast', 'giga-impact', 'thunder-fang', 'ice-fang', 'fire-fang', 'rock-climb', 'stone-edge', 'captivate', 'round', 'incinerate', 'retaliate', 'bulldoze', 'work-up', 'wild-charge', 'snarl', 'play-rough', 'confide', 'dazzling-gleam', 'power-up-punch'], 'name': 'granbull', 'stats': {'hp': 90, 'attack': 120, 'defense': 75, 'special-attack': 60, 'special-defense': 60, 'speed': 45}, 'types': ['fairy'], 'weight': 487, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 20, 'gender_rate': 6, 'capture_rate': 75, 'color': 'purple', 'shape': 'upright', 'habitat': 'urban', 'generation': 'generation-ii', 'growth_rate': 'fast', 'egg_groups': ['ground', 'fairy'], 'names': {'ja-Hrkt': 'グランブル', 'roomaji': 'Granbulu', 'ko': '그랑블루', 'zh-Hant': '布魯皇', 'fr': 'Granbull', 'de': 'Granbull', 'es': 'Granbull', 'it': 'Granbull', 'en': 'Granbull', 'ja': 'グランブル', 'zh-Hans': '布鲁皇'}, 'genera': {'ja-Hrkt': 'ようせいポケモン', 'ko': '요정포켓몬', 'zh-Hant': '妖精寶可夢', 'fr': 'Pokémon Fée', 'de': 'Fee', 'es': 'Pokémon Hada', 'it': 'Pokémon Fata', 'en': 'Fairy Pokémon', 'ja': 'ようせいポケモン', 'zh-Hans': '妖精宝可梦'}}
	public class SpecieGranbull : PokemonSpecie
	{
#nullable enable
		private static SpecieGranbull? _instance = null;
#nullable restore
        public static SpecieGranbull Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieGranbull();
                }
                return _instance;
            }
        }

		public SpecieGranbull() : base(
			"Granbull",
			90, // HPs
			120, 75, // Attack & Defense
			60, 60, // Special Attack & Defense
			45			
		) {}
	}


	//Granbull Pokemon Class
	public class Granbull : Pokemon
	{

		public Granbull(string nickname, int level)
		: base(
				210,
				SpecieGranbull.Instance, // Pokemon Specie
				nickname, level,
				Fairy.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Granbull() : base(
			210,
			SpecieGranbull.Instance, // Pokemon Specie
			Fairy.Instance			
		) {}
	}
}