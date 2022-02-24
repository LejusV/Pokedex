using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Larvitar Specie to store common natural stats of every {'abilities': ['guts', 'sand-veil'], 'base_experience': 60, 'height': 6, 'id': 246, 'moves': ['stomp', 'headbutt', 'body-slam', 'thrash', 'double-edge', 'leer', 'bite', 'hyper-beam', 'earthquake', 'dig', 'toxic', 'mimic', 'screech', 'double-team', 'focus-energy', 'rest', 'rock-slide', 'substitute', 'snore', 'curse', 'spite', 'protect', 'scary-face', 'mud-slap', 'detect', 'outrage', 'sandstorm', 'endure', 'swagger', 'attract', 'sleep-talk', 'return', 'frustration', 'pursuit', 'iron-tail', 'hidden-power', 'rain-dance', 'sunny-day', 'crunch', 'ancient-power', 'rock-smash', 'uproar', 'torment', 'facade', 'taunt', 'superpower', 'brick-break', 'secret-power', 'rock-tomb', 'iron-defense', 'dragon-dance', 'natural-gift', 'payback', 'assurance', 'rock-polish', 'dark-pulse', 'earth-power', 'iron-head', 'stone-edge', 'captivate', 'stealth-rock', 'smack-down', 'round', 'chip-away', 'retaliate', 'bulldoze', 'snarl', 'confide', 'power-up-punch'], 'name': 'larvitar', 'stats': {'hp': 50, 'attack': 64, 'defense': 50, 'special-attack': 45, 'special-defense': 50, 'speed': 41}, 'types': ['rock', 'ground'], 'weight': 720, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 40, 'gender_rate': 4, 'capture_rate': 45, 'color': 'green', 'shape': 'upright', 'habitat': 'mountain', 'generation': 'generation-ii', 'growth_rate': 'slow', 'egg_groups': ['monster'], 'names': {'ja-Hrkt': 'ヨーギラス', 'roomaji': 'Yogiras', 'ko': '애버라스', 'zh-Hant': '幼基拉斯', 'fr': 'Embrylex', 'de': 'Larvitar', 'es': 'Larvitar', 'it': 'Larvitar', 'en': 'Larvitar', 'ja': 'ヨーギラス', 'zh-Hans': '幼基拉斯'}, 'genera': {'ja-Hrkt': 'いわはだポケモン', 'ko': '바위표면포켓몬', 'zh-Hant': '岩石膚寶可夢', 'fr': 'Pokémon Peaupierre', 'de': 'Felshaut', 'es': 'Pokémon Piel Roca', 'it': 'Pokémon Peldisasso', 'en': 'Rock Skin Pokémon', 'ja': 'いわはだポケモン', 'zh-Hans': '岩石肤宝可梦'}}
	public class SpecieLarvitar : PokemonSpecie
	{
#nullable enable
		private static SpecieLarvitar? _instance = null;
#nullable restore
        public static SpecieLarvitar Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieLarvitar();
                }
                return _instance;
            }
        }

		public SpecieLarvitar() : base(
			"Larvitar",
			50, // HPs
			64, 50, // Attack & Defense
			45, 50, // Special Attack & Defense
			41			
		) {}
	}


	//Larvitar Pokemon Class
	public class Larvitar : Pokemon
	{

		public Larvitar(string nickname, int level)
		: base(
				246,
				SpecieLarvitar.Instance, // Pokemon Specie
				nickname, level,
				Rock.Instance, Ground.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Larvitar() : base(
			246,
			SpecieLarvitar.Instance, // Pokemon Specie
			Rock.Instance, Ground.Instance			
		) {}
	}
}