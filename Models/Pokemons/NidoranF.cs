using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Nidoran-F Specie to store common natural stats of every {'abilities': ['poison-point', 'rivalry', 'hustle'], 'base_experience': 55, 'height': 4, 'id': 29, 'moves': ['scratch', 'cut', 'double-kick', 'headbutt', 'tackle', 'body-slam', 'take-down', 'double-edge', 'tail-whip', 'poison-sting', 'bite', 'growl', 'supersonic', 'disable', 'ice-beam', 'blizzard', 'counter', 'strength', 'thunderbolt', 'thunder', 'dig', 'toxic', 'rage', 'mimic', 'double-team', 'defense-curl', 'reflect', 'focus-energy', 'bide', 'skull-bash', 'fury-swipes', 'rest', 'super-fang', 'substitute', 'thief', 'snore', 'curse', 'protect', 'sludge-bomb', 'mud-slap', 'detect', 'endure', 'charm', 'swagger', 'attract', 'sleep-talk', 'return', 'frustration', 'pursuit', 'iron-tail', 'hidden-power', 'rain-dance', 'sunny-day', 'crunch', 'rock-smash', 'beat-up', 'flatter', 'facade', 'helping-hand', 'secret-power', 'poison-fang', 'aerial-ace', 'poison-tail', 'shock-wave', 'water-pulse', 'natural-gift', 'toxic-spikes', 'poison-jab', 'shadow-claw', 'captivate', 'hone-claws', 'venoshock', 'round', 'echoed-voice', 'chip-away', 'confide', 'venom-drench'], 'name': 'nidoran-f', 'stats': {'hp': 55, 'attack': 47, 'defense': 52, 'special-attack': 40, 'special-defense': 40, 'speed': 41}, 'types': ['poison'], 'weight': 70, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 20, 'gender_rate': 8, 'capture_rate': 235, 'color': 'blue', 'shape': 'quadruped', 'habitat': 'grassland', 'generation': 'generation-i', 'growth_rate': 'medium-slow', 'egg_groups': ['monster', 'ground'], 'names': {'ja-Hrkt': 'ニドラン♀', 'roomaji': 'Nidoran♀', 'ko': '니드런♀', 'zh-Hant': '尼多蘭', 'fr': 'Nidoran♀', 'de': 'Nidoran♀', 'es': 'Nidoran♀', 'it': 'Nidoran♀', 'en': 'Nidoran♀', 'ja': 'ニドラン♀', 'zh-Hans': '尼多兰'}, 'genera': {'ja-Hrkt': 'どくばりポケモン', 'ko': '독침포켓몬', 'zh-Hant': '毒針寶可夢', 'fr': 'Pokémon Vénépic', 'de': 'Giftdorn', 'es': 'Pokémon Pin Veneno', 'it': 'Pokémon Velenago', 'en': 'Poison Pin Pokémon', 'ja': 'どくばりポケモン', 'zh-Hans': '毒针宝可梦'}}
	public class SpecieNidoranF : PokemonSpecie
	{
#nullable enable
		private static SpecieNidoranF? _instance = null;
#nullable restore
        public static SpecieNidoranF Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieNidoranF();
                }
                return _instance;
            }
        }

		public SpecieNidoranF() : base(
			"Nidoran-F",
			55, // HPs
			47, 52, // Attack & Defense
			40, 40, // Special Attack & Defense
			41			
		) {}
	}


	//Nidoran-F Pokemon Class
	public class NidoranF : Pokemon
	{

		public NidoranF(string nickname, int level)
		: base(
				29,
				SpecieNidoranF.Instance, // Pokemon Specie
				nickname, level,
				Poison.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public NidoranF() : base(
			29,
			SpecieNidoranF.Instance, // Pokemon Specie
			Poison.Instance			
		) {}
	}
}