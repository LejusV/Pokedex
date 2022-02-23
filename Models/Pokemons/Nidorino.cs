using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Nidorino Specie to store common natural stats of every {'abilities': ['poison-point', 'rivalry', 'hustle'], 'base_experience': 128, 'height': 9, 'id': 33, 'moves': ['cut', 'double-kick', 'headbutt', 'horn-attack', 'fury-attack', 'horn-drill', 'tackle', 'body-slam', 'take-down', 'double-edge', 'poison-sting', 'leer', 'water-gun', 'ice-beam', 'blizzard', 'bubble-beam', 'peck', 'counter', 'strength', 'thunderbolt', 'thunder', 'dig', 'toxic', 'rage', 'mimic', 'double-team', 'defense-curl', 'reflect', 'focus-energy', 'bide', 'skull-bash', 'rest', 'super-fang', 'substitute', 'thief', 'snore', 'curse', 'protect', 'sludge-bomb', 'mud-slap', 'detect', 'endure', 'swagger', 'attract', 'sleep-talk', 'return', 'frustration', 'iron-tail', 'hidden-power', 'rain-dance', 'sunny-day', 'rock-smash', 'flatter', 'facade', 'helping-hand', 'secret-power', 'shock-wave', 'water-pulse', 'natural-gift', 'sucker-punch', 'toxic-spikes', 'poison-jab', 'shadow-claw', 'captivate', 'hone-claws', 'venoshock', 'round', 'echoed-voice', 'drill-run', 'confide', 'smart-strike'], 'name': 'nidorino', 'stats': {'hp': 61, 'attack': 72, 'defense': 57, 'special-attack': 55, 'special-defense': 55, 'speed': 65}, 'types': ['poison'], 'weight': 195, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 20, 'gender_rate': 0, 'capture_rate': 120, 'color': 'purple', 'shape': 'quadruped', 'habitat': 'grassland', 'generation': 'generation-i', 'growth_rate': 'medium-slow', 'egg_groups': ['monster', 'ground'], 'names': {'ja-Hrkt': 'ニドリーノ', 'roomaji': 'Nidorino', 'ko': '니드리노', 'zh-Hant': '尼多力諾', 'fr': 'Nidorino', 'de': 'Nidorino', 'es': 'Nidorino', 'it': 'Nidorino', 'en': 'Nidorino', 'ja': 'ニドリーノ', 'zh-Hans': '尼多力诺'}, 'genera': {'ja-Hrkt': 'どくばりポケモン', 'ko': '독침포켓몬', 'zh-Hant': '毒針寶可夢', 'fr': 'Pokémon Vénépic', 'de': 'Giftdorn', 'es': 'Pokémon Pin Veneno', 'it': 'Pokémon Velenago', 'en': 'Poison Pin Pokémon', 'ja': 'どくばりポケモン', 'zh-Hans': '毒针宝可梦'}}
	public class SpecieNidorino : PokemonSpecie
	{
#nullable enable
		private static SpecieNidorino? _instance = null;
#nullable restore
        public static SpecieNidorino Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieNidorino();
                }
                return _instance;
            }
        }

		public SpecieNidorino() : base(
			"Nidorino",
			61, // HPs
			72, 57, // Attack & Defense
			55, 55, // Special Attack & Defense
			65			
		) {}
	}


	//Nidorino Pokemon Class
	public class Nidorino : Pokemon
	{

		public Nidorino(string nickname, int level) : base(
			33,
			SpecieNidorino.Instance, // Pokemon Specie
			nickname, level,
			Poison.Instance			
		) {}

		public Nidorino() : base(
			33,
			SpecieNidorino.Instance, // Pokemon Specie
			Poison.Instance			
		) {}
	}
}