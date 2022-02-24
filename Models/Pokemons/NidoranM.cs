using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Nidoran-M Specie to store common natural stats of every {'abilities': ['poison-point', 'rivalry', 'hustle'], 'base_experience': 55, 'height': 5, 'id': 32, 'moves': ['cut', 'double-kick', 'headbutt', 'horn-attack', 'fury-attack', 'horn-drill', 'tackle', 'body-slam', 'take-down', 'double-edge', 'poison-sting', 'leer', 'supersonic', 'disable', 'ice-beam', 'blizzard', 'peck', 'counter', 'strength', 'thunderbolt', 'thunder', 'dig', 'toxic', 'confusion', 'rage', 'mimic', 'double-team', 'defense-curl', 'reflect', 'focus-energy', 'bide', 'skull-bash', 'amnesia', 'rest', 'super-fang', 'substitute', 'thief', 'snore', 'curse', 'protect', 'sludge-bomb', 'mud-slap', 'detect', 'endure', 'swagger', 'attract', 'sleep-talk', 'return', 'frustration', 'iron-tail', 'hidden-power', 'rain-dance', 'sunny-day', 'rock-smash', 'beat-up', 'flatter', 'facade', 'helping-hand', 'secret-power', 'poison-tail', 'shock-wave', 'water-pulse', 'natural-gift', 'sucker-punch', 'toxic-spikes', 'poison-jab', 'shadow-claw', 'captivate', 'head-smash', 'hone-claws', 'venoshock', 'round', 'echoed-voice', 'chip-away', 'drill-run', 'confide', 'venom-drench', 'smart-strike'], 'name': 'nidoran-m', 'stats': {'hp': 46, 'attack': 57, 'defense': 40, 'special-attack': 40, 'special-defense': 40, 'speed': 50}, 'types': ['poison'], 'weight': 90, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 20, 'gender_rate': 0, 'capture_rate': 235, 'color': 'purple', 'shape': 'quadruped', 'habitat': 'grassland', 'generation': 'generation-i', 'growth_rate': 'medium-slow', 'egg_groups': ['monster', 'ground'], 'names': {'ja-Hrkt': 'ニドラン♂', 'roomaji': 'Nidoran♂', 'ko': '니드런♂', 'zh-Hant': '尼多朗', 'fr': 'Nidoran♂', 'de': 'Nidoran♂', 'es': 'Nidoran♂', 'it': 'Nidoran♂', 'en': 'Nidoran♂', 'ja': 'ニドラン♂', 'zh-Hans': '尼多朗'}, 'genera': {'ja-Hrkt': 'どくばりポケモン', 'ko': '독침포켓몬', 'zh-Hant': '毒針寶可夢', 'fr': 'Pokémon Vénépic', 'de': 'Giftdorn', 'es': 'Pokémon Pin Veneno', 'it': 'Pokémon Velenago', 'en': 'Poison Pin Pokémon', 'ja': 'どくばりポケモン', 'zh-Hans': '毒针宝可梦'}}
	public class SpecieNidoranM : PokemonSpecie
	{
#nullable enable
		private static SpecieNidoranM? _instance = null;
#nullable restore
        public static SpecieNidoranM Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieNidoranM();
                }
                return _instance;
            }
        }

		public SpecieNidoranM() : base(
			"Nidoran-M",
			46, // HPs
			57, 40, // Attack & Defense
			40, 40, // Special Attack & Defense
			50			
		) {}
	}


	//Nidoran-M Pokemon Class
	public class NidoranM : Pokemon
	{

		public NidoranM(string nickname, int level)
		: base(
				32,
				SpecieNidoranM.Instance, // Pokemon Specie
				nickname, level,
				Poison.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public NidoranM(int level)
		: base(
				32,
				SpecieNidoranM.Instance, // Pokemon Specie
				"Nidoran-M", level,
				Poison.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public NidoranM() : base(
			32,
			SpecieNidoranM.Instance, // Pokemon Specie
			Poison.Instance			
		) {}
	}
}