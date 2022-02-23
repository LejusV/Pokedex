using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Corsola Specie to store common natural stats of every {'abilities': ['hustle', 'natural-cure', 'regenerator'], 'base_experience': 144, 'height': 6, 'id': 222, 'moves': ['headbutt', 'tackle', 'body-slam', 'double-edge', 'mist', 'surf', 'ice-beam', 'blizzard', 'bubble-beam', 'strength', 'earthquake', 'dig', 'toxic', 'psychic', 'mimic', 'screech', 'double-team', 'recover', 'harden', 'confuse-ray', 'defense-curl', 'barrier', 'light-screen', 'reflect', 'bide', 'self-destruct', 'spike-cannon', 'amnesia', 'bubble', 'explosion', 'rest', 'rock-slide', 'substitute', 'snore', 'curse', 'flail', 'protect', 'mud-slap', 'icy-wind', 'sandstorm', 'endure', 'rollout', 'swagger', 'attract', 'sleep-talk', 'return', 'frustration', 'safeguard', 'hidden-power', 'rain-dance', 'sunny-day', 'mirror-coat', 'ancient-power', 'shadow-ball', 'rock-smash', 'whirlpool', 'hail', 'facade', 'nature-power', 'ingrain', 'magic-coat', 'endeavor', 'refresh', 'secret-power', 'camouflage', 'rock-tomb', 'icicle-spear', 'iron-defense', 'calm-mind', 'rock-blast', 'water-pulse', 'brine', 'natural-gift', 'lucky-chant', 'sucker-punch', 'aqua-ring', 'rock-polish', 'power-gem', 'earth-power', 'stone-edge', 'captivate', 'stealth-rock', 'head-smash', 'round', 'scald', 'bulldoze', 'confide', 'liquidation'], 'name': 'corsola', 'stats': {'hp': 65, 'attack': 55, 'defense': 95, 'special-attack': 65, 'special-defense': 95, 'speed': 35}, 'types': ['water', 'rock'], 'weight': 50, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 20, 'gender_rate': 6, 'capture_rate': 60, 'color': 'pink', 'shape': 'armor', 'habitat': 'sea', 'generation': 'generation-ii', 'growth_rate': 'fast', 'egg_groups': ['water1', 'water3'], 'names': {'ja-Hrkt': 'サニーゴ', 'roomaji': 'Sunnygo', 'ko': '코산호', 'zh-Hant': '太陽珊瑚', 'fr': 'Corayon', 'de': 'Corasonn', 'es': 'Corsola', 'it': 'Corsola', 'en': 'Corsola', 'ja': 'サニーゴ', 'zh-Hans': '太阳珊瑚'}, 'genera': {'ja-Hrkt': 'さんごポケモン', 'ko': '산호포켓몬', 'zh-Hant': '珊瑚寶可夢', 'fr': 'Pokémon Corail', 'de': 'Koralle', 'es': 'Pokémon Coral', 'it': 'Pokémon Corallo', 'en': 'Coral Pokémon', 'ja': 'さんごポケモン', 'zh-Hans': '珊瑚宝可梦'}}
	public class SpecieCorsola : PokemonSpecie
	{
#nullable enable
		private static SpecieCorsola? _instance = null;
#nullable restore
        public static SpecieCorsola Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieCorsola();
                }
                return _instance;
            }
        }

		public SpecieCorsola() : base(
			"Corsola",
			65, // HPs
			55, 95, // Attack & Defense
			65, 95, // Special Attack & Defense
			35			
		) {}
	}


	//Corsola Pokemon Class
	public class Corsola : Pokemon
	{

		public Corsola(string nickname, int level) : base(
			222,
			SpecieCorsola.Instance, // Pokemon Specie
			nickname, level,
			Water.Instance, Rock.Instance			
		) {}

		public Corsola() : base(
			222,
			SpecieCorsola.Instance, // Pokemon Specie
			Water.Instance, Rock.Instance			
		) {}
	}
}