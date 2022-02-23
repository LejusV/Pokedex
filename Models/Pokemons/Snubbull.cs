using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Snubbull Specie to store common natural stats of every {'abilities': ['intimidate', 'run-away', 'rattled'], 'base_experience': 60, 'height': 6, 'id': 209, 'moves': ['mega-punch', 'fire-punch', 'ice-punch', 'thunder-punch', 'mega-kick', 'headbutt', 'tackle', 'body-slam', 'take-down', 'double-edge', 'tail-whip', 'leer', 'bite', 'roar', 'flamethrower', 'low-kick', 'counter', 'seismic-toss', 'strength', 'solar-beam', 'thunderbolt', 'thunder-wave', 'thunder', 'earthquake', 'dig', 'toxic', 'rage', 'mimic', 'double-team', 'defense-curl', 'reflect', 'metronome', 'lick', 'fire-blast', 'rest', 'super-fang', 'substitute', 'thief', 'snore', 'curse', 'protect', 'scary-face', 'feint-attack', 'sludge-bomb', 'mud-slap', 'zap-cannon', 'detect', 'endure', 'charm', 'swagger', 'attract', 'sleep-talk', 'heal-bell', 'return', 'present', 'frustration', 'dynamic-punch', 'hidden-power', 'rain-dance', 'sunny-day', 'crunch', 'shadow-ball', 'rock-smash', 'torment', 'facade', 'focus-punch', 'smelling-salts', 'taunt', 'superpower', 'brick-break', 'secret-power', 'hyper-voice', 'fake-tears', 'overheat', 'bulk-up', 'covet', 'shock-wave', 'water-pulse', 'natural-gift', 'close-combat', 'payback', 'fling', 'last-resort', 'thunder-fang', 'ice-fang', 'fire-fang', 'captivate', 'round', 'incinerate', 'retaliate', 'bulldoze', 'work-up', 'wild-charge', 'snarl', 'play-rough', 'confide', 'dazzling-gleam', 'power-up-punch'], 'name': 'snubbull', 'stats': {'hp': 60, 'attack': 80, 'defense': 50, 'special-attack': 40, 'special-defense': 40, 'speed': 30}, 'types': ['fairy'], 'weight': 78, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 20, 'gender_rate': 6, 'capture_rate': 190, 'color': 'pink', 'shape': 'humanoid', 'habitat': 'urban', 'generation': 'generation-ii', 'growth_rate': 'fast', 'egg_groups': ['ground', 'fairy'], 'names': {'ja-Hrkt': 'ブルー', 'roomaji': 'Bulu', 'ko': '블루', 'zh-Hant': '布魯', 'fr': 'Snubbull', 'de': 'Snubbull', 'es': 'Snubbull', 'it': 'Snubbull', 'en': 'Snubbull', 'ja': 'ブルー', 'zh-Hans': '布鲁'}, 'genera': {'ja-Hrkt': 'ようせいポケモン', 'ko': '요정포켓몬', 'zh-Hant': '妖精寶可夢', 'fr': 'Pokémon Fée', 'de': 'Fee', 'es': 'Pokémon Hada', 'it': 'Pokémon Fata', 'en': 'Fairy Pokémon', 'ja': 'ようせいポケモン', 'zh-Hans': '妖精宝可梦'}}
	public class SpecieSnubbull : PokemonSpecie
	{
#nullable enable
		private static SpecieSnubbull? _instance = null;
#nullable restore
        public static SpecieSnubbull Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieSnubbull();
                }
                return _instance;
            }
        }

		public SpecieSnubbull() : base(
			"Snubbull",
			60, // HPs
			80, 50, // Attack & Defense
			40, 40, // Special Attack & Defense
			30			
		) {}
	}


	//Snubbull Pokemon Class
	public class Snubbull : Pokemon
	{

		public Snubbull(string nickname, int level) : base(
			209,
			SpecieSnubbull.Instance, // Pokemon Specie
			nickname, level,
			Fairy.Instance			
		) {}

		public Snubbull() : base(
			209,
			SpecieSnubbull.Instance, // Pokemon Specie
			Fairy.Instance			
		) {}
	}
}