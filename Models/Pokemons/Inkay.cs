using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Inkay Specie to store common natural stats of every {'abilities': ['contrary', 'suction-cups', 'infiltrator'], 'base_experience': 58, 'height': 4, 'id': 686, 'moves': ['cut', 'bind', 'tackle', 'flamethrower', 'psybeam', 'peck', 'thunderbolt', 'toxic', 'psychic', 'hypnosis', 'double-team', 'light-screen', 'reflect', 'constrict', 'flash', 'psywave', 'rest', 'rock-slide', 'slash', 'substitute', 'thief', 'snore', 'spite', 'protect', 'destiny-bond', 'swagger', 'attract', 'sleep-talk', 'return', 'frustration', 'hidden-power', 'rain-dance', 'sunny-day', 'psych-up', 'torment', 'flatter', 'facade', 'taunt', 'role-play', 'superpower', 'knock-off', 'snatch', 'secret-power', 'camouflage', 'aerial-ace', 'calm-mind', 'pluck', 'payback', 'embargo', 'fling', 'guard-swap', 'dark-pulse', 'night-slash', 'switcheroo', 'psycho-cut', 'trick-room', 'power-split', 'foul-play', 'simple-beam', 'round', 'retaliate', 'topsy-turvy', 'confide'], 'name': 'inkay', 'stats': {'hp': 53, 'attack': 54, 'defense': 53, 'special-attack': 37, 'special-defense': 46, 'speed': 45}, 'types': ['dark', 'psychic'], 'weight': 35, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 20, 'gender_rate': 4, 'capture_rate': 190, 'color': 'blue', 'shape': 'tentacles', 'habitat': None, 'generation': 'generation-vi', 'growth_rate': 'medium', 'egg_groups': ['water1', 'water2'], 'names': {'ja-Hrkt': 'マーイーカ', 'ko': '오케이징', 'zh-Hant': '好啦魷', 'fr': 'Sepiatop', 'de': 'Iscalar', 'es': 'Inkay', 'it': 'Inkay', 'en': 'Inkay', 'ja': 'マーイーカ', 'zh-Hans': '好啦鱿'}, 'genera': {'ja-Hrkt': 'かいてんポケモン', 'ko': '회전포켓몬', 'zh-Hant': '回轉寶可夢', 'fr': 'Pokémon Rotation', 'de': 'Rotation', 'es': 'Pokémon Rotación', 'it': 'Pokémon Volteggio', 'en': 'Revolving Pokémon', 'ja': 'かいてんポケモン', 'zh-Hans': '回转宝可梦'}}
	public class SpecieInkay : PokemonSpecie
	{
#nullable enable
		private static SpecieInkay? _instance = null;
#nullable restore
        public static SpecieInkay Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieInkay();
                }
                return _instance;
            }
        }

		public SpecieInkay() : base(
			"Inkay",
			53, // HPs
			54, 53, // Attack & Defense
			37, 46, // Special Attack & Defense
			45			
		) {}
	}


	//Inkay Pokemon Class
	public class Inkay : Pokemon
	{

		public Inkay(string nickname, int level)
		: base(
				686,
				SpecieInkay.Instance, // Pokemon Specie
				nickname, level,
				Dark.Instance, Psychic.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Inkay(int level)
		: base(
				686,
				SpecieInkay.Instance, // Pokemon Specie
				"Inkay", level,
				Dark.Instance, Psychic.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Inkay() : base(
			686,
			SpecieInkay.Instance, // Pokemon Specie
			Dark.Instance, Psychic.Instance			
		) {}
	}
}