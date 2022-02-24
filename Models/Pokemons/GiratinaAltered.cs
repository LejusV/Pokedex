using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Giratina-Altered Specie to store common natural stats of every {'abilities': ['pressure', 'telepathy'], 'base_experience': 306, 'height': 45, 'id': 487, 'moves': ['cut', 'fly', 'headbutt', 'roar', 'hyper-beam', 'strength', 'thunderbolt', 'thunder-wave', 'thunder', 'earthquake', 'toxic', 'psychic', 'double-team', 'swift', 'dream-eater', 'rest', 'slash', 'substitute', 'snore', 'spite', 'protect', 'scary-face', 'mud-slap', 'destiny-bond', 'icy-wind', 'outrage', 'endure', 'swagger', 'fury-cutter', 'steel-wing', 'sleep-talk', 'return', 'frustration', 'safeguard', 'pain-split', 'dragon-breath', 'iron-tail', 'hidden-power', 'twister', 'rain-dance', 'sunny-day', 'psych-up', 'ancient-power', 'shadow-ball', 'rock-smash', 'will-o-wisp', 'facade', 'secret-power', 'hyper-voice', 'air-cutter', 'silver-wind', 'aerial-ace', 'dragon-claw', 'calm-mind', 'shock-wave', 'gravity', 'natural-gift', 'payback', 'heal-block', 'aura-sphere', 'dark-pulse', 'aqua-tail', 'dragon-pulse', 'energy-ball', 'earth-power', 'giga-impact', 'shadow-claw', 'shadow-sneak', 'rock-climb', 'defog', 'draco-meteor', 'iron-head', 'stone-edge', 'charge-beam', 'ominous-wind', 'shadow-force', 'hone-claws', 'telekinesis', 'round', 'echoed-voice', 'hex', 'bulldoze', 'dragon-tail', 'confide', 'brutal-swing'], 'name': 'giratina-altered', 'stats': {'hp': 150, 'attack': 100, 'defense': 120, 'special-attack': 100, 'special-defense': 120, 'speed': 90}, 'types': ['ghost', 'dragon'], 'weight': 7500, 'is_baby': False, 'is_legendary': True, 'is_mythical': False, 'hatch_counter': 120, 'gender_rate': -1, 'capture_rate': 3, 'color': 'black', 'shape': 'tentacles', 'habitat': None, 'generation': 'generation-iv', 'growth_rate': 'slow', 'egg_groups': ['no-eggs'], 'names': {'ja-Hrkt': 'ギラティナ', 'roomaji': 'Giratina', 'ko': '기라티나', 'zh-Hant': '騎拉帝納', 'fr': 'Giratina', 'de': 'Giratina', 'es': 'Giratina', 'it': 'Giratina', 'en': 'Giratina', 'ja': 'ギラティナ', 'zh-Hans': '骑拉帝纳'}, 'genera': {'ja-Hrkt': 'はんこつポケモン', 'ko': '반골포켓몬', 'zh-Hant': '反抗寶可夢', 'fr': 'Pokémon Renégat', 'de': 'Rebell', 'es': 'Pokémon Renegado', 'it': 'Pokémon Ribelle', 'en': 'Renegade Pokémon', 'ja': 'はんこつポケモン', 'zh-Hans': '反抗宝可梦'}}
	public class SpecieGiratinaAltered : PokemonSpecie
	{
#nullable enable
		private static SpecieGiratinaAltered? _instance = null;
#nullable restore
        public static SpecieGiratinaAltered Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieGiratinaAltered();
                }
                return _instance;
            }
        }

		public SpecieGiratinaAltered() : base(
			"Giratina-Altered",
			150, // HPs
			100, 120, // Attack & Defense
			100, 120, // Special Attack & Defense
			90			
		) {}
	}


	//Giratina-Altered Pokemon Class
	public class GiratinaAltered : Pokemon
	{

		public GiratinaAltered(string nickname, int level)
		: base(
				487,
				SpecieGiratinaAltered.Instance, // Pokemon Specie
				nickname, level,
				Ghost.Instance, Dragon.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public GiratinaAltered(int level)
		: base(
				487,
				SpecieGiratinaAltered.Instance, // Pokemon Specie
				"Giratina-Altered", level,
				Ghost.Instance, Dragon.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public GiratinaAltered() : base(
			487,
			SpecieGiratinaAltered.Instance, // Pokemon Specie
			Ghost.Instance, Dragon.Instance			
		) {}
	}
}